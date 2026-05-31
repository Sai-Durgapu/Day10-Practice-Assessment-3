console.log("JavaScript Loaded Successfully");

document.addEventListener("DOMContentLoaded", function () {

    const button = document.getElementById("btnClick");

    button.addEventListener("click", function () {

        alert("Button Clicked Successfully!");

    });

});