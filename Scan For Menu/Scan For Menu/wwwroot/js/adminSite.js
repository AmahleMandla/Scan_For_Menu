const inputs = document.querySelectorAll(".input");


function addcl() {
    let parent = this.parentNode.parentNode;
    parent.classList.add("focus");
}

function remcl() {
    let parent = this.parentNode.parentNode;
    if (this.value == "") {
        parent.classList.remove("focus");
    }
}


inputs.forEach(input => {
    input.addEventListener("focus", addcl);
    input.addEventListener("blur", remcl);
});

function RemoveComplete(itemToRemove, Model) {
    // alert(itemQty);

    var formdata = new FormData();

    formdata.append("obj", itemToRemove);
    formdata.append("Model", Model);

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
