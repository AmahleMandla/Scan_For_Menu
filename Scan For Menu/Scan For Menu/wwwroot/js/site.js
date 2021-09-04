﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
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
function increment() {
    document.getElementById('item_qty').stepUp();
}

function decrement() {
    document.getElementById('item_qty').stepDown();
}

//scroll to top of screen
function scrollToTop() {
    window.scrollTo(0, 0);
}