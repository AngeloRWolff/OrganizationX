// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function openCsv(event) {
    var input = event.target;
    var reader = new FileReader();
    var textField = document.getElementById('loadTextField');
    reader.onload = function () {
        var data = reader.result;
        textField.innerHTML = atob(data.split(',')[1]);
    };
    reader.readAsDataURL(input.files[0]);

};