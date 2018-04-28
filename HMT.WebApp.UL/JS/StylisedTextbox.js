/**
 * Script developed by Bradley Turner
 * Created:     13/03/18
 * Modified:    13/03/18        created functions choosePlaceholder(caller), reveal(caller), hide(caller)
 */

//function to reset the placeholder text of certain elements
function choosePlaceholder(caller) {
    switch (caller.id) {
        case "ContentPlaceHolder1_fname":
            return "First name *";
        case "ContentPlaceHolder1_lname":
            return "Surname *";
        case "ContentPlaceHolder1_txtEmail":
            return "Email *";
        case "ContentPlaceHolder1_pass1":
            return "Password *";
        case "ContentPlaceHolder1_pass2":
            return "Confirm Password *";
        default:
            return "";
    }
}

/*function removes placeholder text, creates an outline and renders the sibling span visible
 *caller must be an asp:textbox in the DOM structure of:
 *  -div
 *      -span
 *      -asp:textbox (caller)
 */
function reveal(caller) {
    caller.placeholder = "";
    caller.parentNode.style.outline = "0.5px solid lightgrey";
    caller.previousElementSibling.style.visibility = "visible";
}

/**function reverses the effects of reveal()
 * must be in the same DOM structure as reveal
 */
function hide(caller) {
    if (!caller.value) {
        caller.previousElementSibling.style.visibility = "hidden";
    } else {
        caller.nextElementSibling.style.visibility = "hidden";
    }
    
    caller.placeholder = choosePlaceholder(caller);
    caller.parentNode.style.outline = "none";
}