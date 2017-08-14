$(document).ready(function () {
    // add rules for Title field
    $("#Title").rules("add", {
        minlength: 2,
        maxlength: 20,
        messages: {
            minlength: jQuery.validator.format("Please, at least {0} characters are necessary"),
            maxlength: jQuery.validator.format("Please, no more than {0} characters are allowed")
        }
    })

})