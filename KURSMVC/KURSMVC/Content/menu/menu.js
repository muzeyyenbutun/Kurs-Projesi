$().ready(function () {

    $("#tostmenu").click(function () {
        if ($(".menu>ul").is(":visible")) {
            $(".menu>ul").css("display", "none");
        }
        else {
            $(".menu>ul").css("display", "block");
        }
    });

    $(window).resize(function () {
        if (this.window.innerWidth > 560) {
            $(".menu>ul").css("display", "block");
        }
    });
});