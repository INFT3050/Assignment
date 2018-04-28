function modify(group) {
    var textbox = group.children[1];
    var image = group.children[2];

    if (textbox.readOnly == true) {
        textbox.readOnly = false;
        textbox.style.border = "1px solid darkgrey";
        //image.onclick = saveChanges(group);
    }
}

function saveChanges(group) {
    var textbox = group.children[1];
    var image = group.children[2];

    if (textbox.readOnly == false) {
        textbox.readOnly = true;
        textbox.style.border = "none";
    }
}