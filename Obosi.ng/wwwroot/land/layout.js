var eventRegister = $("#event-register");


$(document).ready(function () {

    function toggleNavigation() {

        //if ($(".top-dropdown").hasClass("active")) {
        //    $(".show-top-dropdown.active").click();
        //}

        $(".nav-button").toggleClass("active");
        $("header nav").toggleClass("active");
        $(".logo-links").toggleClass("active");

        $("body").toggleClass("open");

    }

    function toggleDropdown() {

        $(".top-dropdown").toggleClass("active");

        if ($("#nav-btn").css('display') == 'none') {
            $("body").removeClass("open");

        }

        $(".top-dropdown-contents.active").removeClass("active");
       
    }

    $(".nav-button").on("click tap", function () {
        toggleNavigation();
    });

    $(".dropdown-button").on("click tap", function () {
        toggleDropdown();
    });

    $(document).keyup(function (e) {
        if (e.keyCode === 27) {
            toggleNavigation();
        }
    });

    

});

eventRegister.on("click", ".show-top-dropdown", function (e) {

    e.preventDefault();

    var that = $(this);

    $(that.data("target")).addClass("active");

    $(".top-dropdown").addClass("active");

    /*$(".dropdown-button").toggleClass("active");*/

    if (!$("body").hasClass("open")) {
        $("body").addClass("open");
    }





    //var nav = $("nav");

    //var activeDropdownLink = $(".show-top-dropdown.active");

    //var activeDropdown = $(".top-dropdown-contents.active");

    //if (that.hasClass("active")) {
    //    that.removeClass("active");
    //    target.removeClass("active");
    //    parent.removeClass("active");
    //}
    //else {

    //    if (nav.hasClass("active")) {
    //        $(".nav-button").click();
    //    }

    //    activeDropdownLink.removeClass("active");
    //    activeDropdown.removeClass("active");
    //    that.addClass("active");
    //    target.addClass("active");

    //    if (!parent.hasClass("active")) {
    //        parent.addClass("active")
    //    }
    //}

    
});

eventRegister.on("click", "#show-page-links", function (e) {

    e.preventDefault();

    $(this).toggleClass("active");

    $(".page-link").toggleClass("active");

});