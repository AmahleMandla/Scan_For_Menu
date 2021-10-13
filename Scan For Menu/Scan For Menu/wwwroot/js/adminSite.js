
function RemoveComplete(itemToRemove) {
    // alert(itemQty);

    var formdata = new FormData();

    formdata.append("orderNum", itemToRemove);

    $.ajax({
        async: true,
        type: 'POST',
        contentType: false,
        processData: false,
        url: '/Kitchen/remove',
        data: formdata,
        success: function (data) {
            if (data.success) {
                alert("Remove")
                // $("#cartItem").text(data.Counter);
            }
        },
        error: function () {
            alert("Unable to remove order")
        }
    });
}

function checkPassword() {
    var x = document.getElementById("password");
    if (x.type === "password") {
        x.type = "text";
    } else {
        x.type = "password";
    }
}

function print(snackbarID) {
    var x = document.getElementById(snackbarID);
    // Add the "show" class to DIV
    x.className = "show";
    // After 3 seconds, remove the show class from DIV
    setTimeout(function () { x.className = x.className.replace("show", ""); }, 3000);
}
