// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

function openPage(pageName, elmnt) {
    // Hide all elements with class="tabcontent" by default */
    var i, tabcontent, tablinks;
    tabcontent = document.getElementsByClassName("tabcontent");
    for (i = 0; i < tabcontent.length; i++) {
        tabcontent[i].style.display = "none";
    }

    // Remove the background color of all tablinks/buttons
    tablinks = document.getElementsByClassName("tablink");
    for (i = 0; i < tablinks.length; i++) {
        tablinks[i].style.backgroundColor = "";
        tablinks[i].style.color = "moccasin";
    }

    // Show the specific tab content
    document.getElementById(pageName).style.display = "block";

    // Add the specific color to the button used to open the tab content
    elmnt.style.backgroundColor = 'moccasin';
    elmnt.style.color = "black";

    scrollToTop();
}

// Get the element with id="defaultOpen" and click on it
document.getElementById("defaultOpen").click();

//incease and decrease elements in an order
function increment(id) {
    var x = document.getElementsByClassName("tableNum");
    x[id].stepUp();
}

function decrement(id) {
    var x = document.getElementsByClassName("tableNum");
    x[id].stepDown();
}

//scroll to top of screen
function scrollToTop() {
    window.scrollTo(0, 0);
}

function getTblNo(btn, list) {
    //get button
    var btnOK = document.getElementById(btn);
    //get value of table number
    var tblNo = document.getElementById(list).value;

    if ((tblNo >= 1) && (tblNo <= 10)) {
        btnOK.style.visibility = "visible";
    } else {
        btnOK.style.visibility = "hidden";
        alert("Please select Your Table Number");

    }
}

function snackbar() {
    // Get the snackbar DIV
}

function addToCart(item, quantity, snackbarID) {

    var x = document.getElementById(snackbarID);
    // Add the "show" class to DIV
    x.className = "show";
    // After 3 seconds, remove the show class from DIV
    setTimeout(function () { x.className = x.className.replace("show", ""); }, 3000);

    var itemId = $(item).attr("itemid");
    //var itemQty = $(quantity).attr("togNo")
    var itemQty = document.getElementById(quantity).value;
    document.getElementById(quantity).value = 0;
    // alert(itemQty);

    var formdata = new FormData();

    formdata.append("itemId", itemId);
    formdata.append("quantity", itemQty);

    $.ajax({
        async: true,
        type: 'POST',
        contentType: false,
        processData: false,
        url: '/Cart/shoppingCart',
        data: formdata,
        success: function (data) {
            if (data.success) {
                alert("Added to cart")
                // $("#cartItem").text(data.Counter);
            }
        },
        error: function () {
            alert("Unable to add to cart")
        }
    });
}


//calculate the gratuity'
function calcTotal(subtotal, gratuityId) {
    var gratuity = parseInt(document.getElementById(gratuityId).value);
    var total = 0;
    var subtotalNew = parseFloat(subtotal);
    if (gratuity >= 0) {
        total = gratuity + subtotalNew;
    }
    else {
        total = subtotalNew;
    }
   
    // alert(total);
    var y = document.getElementById("totals").rows;
    var x = y[3].cells;
    x[1].innerHTML = "R " + total;    
}

function updateCart(item, quantity) {

    var itemId = $(item).attr("itemid");
    var itemQty = document.getElementById(quantity).value;

    var formdata = new FormData();

    formdata.append("itemId", itemId);
    formdata.append("quantity", itemQty);
  
    $.ajax({
        async: true,
        type: 'POST',
        contentType: false,
        processData: false,
        url: '/Cart/updateCart',
        data: formdata,
        success: function () {
            location.reload();
            if (data.success) {
                alert("Added to cart");
                // $("#cartItem").text(data.Counter);
            }
        },
        error: function () {
            location.reload();
            //alert("Unable to add to cart")
        }
    });
}

function printBill(tableNumber) {
    var tableNum = tableNumber;
    var formdata = new FormData();

    formdata.append("tableNumber", tableNum);


    $.ajax({
        async: true,
        type: 'POST',
        contentType: false,
        processData: false,
        url: '/Waiter/PrintBill',
        data: formdata,
        success: function (data) {
            if (data.success) {
                // alert("Added to cart")
                // $("#cartItem").text(data.Counter);
            }
        },
        error: function () {
            //alert("Unable to add to cart")
        }
    });
}
function EnableBtn(cname, ccnum, expmonth, cvv) {
    var btnProceed = document.getElementById('cardPayment');
    if (cname.value != '' && ccnum.value != '' && expmonth.value != '' && cvv.value != '') {
        btnProceed.disabled = false;
    }
    else {
        btnProceed.disabled = true;
    }
}

function hourglass() {
    var a;
    a = document.getElementById("div1");
    a.innerHTML = "&#xf251;";
    setTimeout(function () {
        a.innerHTML = "&#xf252;";
    }, 1000);
    setTimeout(function () {
        a.innerHTML = "&#xf253;";
    }, 2000);
}
hourglass();
setInterval(hourglass, 3000);





























/*
//get table number
function setTableNo(Id) {
    tblNo = document.getElementById(Id).value;
}

//return the table number
function gettableNo() {
    return tblNo;
}

$(document).ready(function () {
    $("#btnClick").click(function () {
        $("#tableNo").modal("show");
    });

    setTableNo("#table_numbers")

    $("#close").click(function () {
      
        $("#tableNo").modal("hide");
    });
});
*/
