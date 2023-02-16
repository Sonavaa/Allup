$(document).ready(function () {
    $(".productModal").click(function (e) {
        e.preventDefault();

        let url = $(this).attr('href');
        console.log(url);
    })
})