$(document).ready(function () {
    $.ajax({
        method: "GET",
        url: "Stock/GetStockTable",
        success: function (res) {
            $("#stockTable").html(res);
        },
        error: function (err) {
            console.error(err);
        }
    });
});