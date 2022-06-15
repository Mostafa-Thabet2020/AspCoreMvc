// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.


// Write your JavaScript code.


$("#TestBtn").click(function () {
    console.log("Function work well");
    TestJson();
});

function TestJson() {
    console.log("worked");
    $.ajax({
        url: "/Students/GetStudentsList",
        type: "GET",
        success: function (data) {
            console.log(data);
            $("#Header").append(data.firstName+" "+data.lastName);
        },
        error: function (jqXHR, textStatus, errorThrown) {
            console.error(textStatus);
        }
    });
}
