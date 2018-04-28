/**
 * Script developed by Bradley Turner
 * Created:     13/03/18
 * Modified:    15/03/18        created functions checkEmpty(), checkPasswordMatch(), checkEmail()
 *              16/03/18        redefined checkEmpty(), checkPasswordMatch() and checkEmail() to be generic allowing for reuse
 *
 *
 *  checkEmpty(textboxList, errorMsgList)
 *      Preconditions:  textboxList and errorMsgList are initialised AND textboxList.length === textboxList.length.
 *      Postconditions: Checks the validation of textboxList elements, returns false if a textbox value is empty and sets its associated errorMsg to visible.
 *
 *
 *  checkPasswordMatch(textbox1, textbox2, errorLabel1)
 *      Preconditions:  textbox1, textbox2 and errorLabel1 are all initialised AND errorLabel1 is the label associated with textbox1.
 *      Postconditions: Compares the values of textbox1 and textbox2, if they are NOT the same, sends an error message to errorLabel1 AND returns false.
 *
 *
 *  checkEmail(txtEmail, emailErrorMsg)
 *      Preconditions:  txtEmail, and errorMsg are intialised
 *      Postconditions: Compares txtEmail to a precomputed regex to validate the field. If regex test fails, return false.
 */


function checkEmpty(textboxList, errorMsgList) {
    var val = true;
    var i;
    function chooseErrorMessage(i) {    //helper function to choose the correct output text for a selected error message
        switch (i) {
            case 0:
                return "First Name";
            case 1:
                return "Surname";
            case 2:
                return "Email";
            case 3:
                return "Address"
            case 4:
                return "Password";
            case 5:
                return "Confirm Password";
        }
    }
    
    for (i = 0; i < textboxList.length; i++) {   //loop through all textboxes in the form and if empty, show empty field error message.
        if (!textboxList[i].value) {
            errorMsgList[i].style.visibility = "visible";
            errorMsgList[i].textContent = "Please enter a value for " + chooseErrorMessage(i);
            val = false;
        }
    }

    if (!val) {
        return false;
    }

    return true;
}

function checkPasswordMatch(textbox1, textbox2, errorLabel1) {     //function to compare the values for password and confirm password
    if (textbox1.value !== textbox2.value) {
        errorLabel1.style.visibility = "visible";
        errorLabel1.textContent = "Passwords do not match";
        textbox1.value = "";
        textbox2.value = "";
        return false;
    }

    return true;
}

function checkEmail(txtEmail, emailErrorMsg) { /*regex email verification, code sourced from https://stackoverflow.com/questions/46155/how-to-validate-an-email-address-in-javascript on date 15/03/18, adapted by bradley turner*/
    var re = /^(([^<>()\[\]\\.,;:\s@"]+(\.[^<>()\[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
    var em = re.test(String(txtEmail.value).toLowerCase());

    if (!em) {
        emailErrorMsg.style.visibility = "visible";
        emailErrorMsg.textContent = "Please enter a valid email address";
    }
    return em;
}


function validate_register() {
    var arr_txtbox = document.getElementsByClassName("inputTxt");
    var arr_errorMsgs = document.getElementsByClassName("errorMsg");
    var valid = true;
    
    if (!checkEmail(arr_txtbox[2], arr_errorMsgs[2])) {
        console.log("failed checkEmail");
        valid = false;
    }
    if (!checkEmpty(arr_txtbox, arr_errorMsgs)) {
        console.log("failed checkEmpty");
        valid = false;
    }
    
    if (!checkPasswordMatch(arr_txtbox[arr_txtbox.length - 2], arr_txtbox[arr_txtbox.length - 1], arr_errorMsgs[arr_errorMsgs.length - 2])) {
        console.log("failed checkMatch");
        valid = false;
    }
    
    return valid;
}



function validate_detailChange() {
    var arr_txtbox = document.getElementsByClassName("displayBox");
    var arr_errorMsgs = document.getElementsByClassName("errorMsg");
    var valid = true;

    if (!checkEmail(arr_txtbox[2], arr_errorMsgs[2])) {
        console.log("failed checkEmail");
        valid = false;
    }
    if (!checkEmpty(arr_txtbox, arr_errorMsgs)) {
        console.log("failed checkEmpty");
        valid = false;
    }

    if (!checkPasswordMatch(arr_txtbox[arr_txtbox.length - 2], arr_txtbox[arr_txtbox.length - 1], arr_errorMsgs[arr_errorMsgs.length - 2])) {
        console.log("failed checkMatch");
        valid = false;
    }

    return valid;
}


