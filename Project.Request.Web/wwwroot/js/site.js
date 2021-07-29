// checks BusinessJustification checkbox checked
function validation() {
    var checkBoxes = document.getElementsByName("BusinessJustification[]");

    var isChecked = 0;
    for (var i = 0; i < checkBoxes.length; i++) {
        if (checkBoxes[i].checked) {
            isChecked++;
        }
    }
    // if no checkboxes are checked
    if (isChecked == 0) {
        document.getElementById("validationMessage").innerHTML = "The Business Justification field is required";
        return true;
    } else {
        document.getElementById("validationMessage").innerHTML = "";

        return true;
    }
}

function validationDepartments() {
    var checkBoxes = document.getElementsByName("DepartmentIds[]");

    var isChecked = 0;
    for (var i = 0; i < checkBoxes.length; i++) {
        if (checkBoxes[i].checked) {
            isChecked++;
        }
    }
    // if no checkboxes are checked
    if (isChecked == 0) {
        document.getElementById("validationMessageDepartment").innerHTML = "The Department field is required";
        return true;
    } else {
        document.getElementById("validationMessageDepartment").innerHTML = "";

        return true;
    }
}

// change validation message to empty if the box is clicked
function clickedValidation() {
    document.getElementById("validationMessage").innerHTML = "";

}
function clickedValidationDepartment(){
    document.getElementById("validationMessageDepartment").innerHTML = "";
}