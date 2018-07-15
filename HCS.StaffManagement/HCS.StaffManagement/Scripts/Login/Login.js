$(document).ready(function () {
    $("#btnLogin").off("click").on("click", function (e) {
        e.preventDefault();
        var emailID = $("#txtEmail").val();
        var password = $("#txtPassword").val();
        if (emailID === "sapsecurity@gmail.com" && password === "password") {
            $("#divError").html("");
            window.location.href = "/Home/AdminDashBoard/";
        } else { $("#divError").html("Please enter valid credentials"); }
    });

    $("input").change(function () {
        $("#divError").html("");
        //if ($("#divError").html() != "") {
        //    $("#divError").html("");
        //}
    });
});