$(function () {

    var registerUserCheckBox = $("#AcceptUserAgreement").click(
        onToggleRegisterUserDisabledClick);

    var registerUserButton = $(".register-user-panel button").click(
        onRegisterUserClick);

    /*User Agreement Check Box*/
    function onToggleRegisterUserDisabledClick() {
        $(".register-user-panel button").toggleClass("disabled");
    }
    // register User button
    function onRegisterUserClick() {
        var url = "/Account/RegisterUserAsync";
        var antiForgery = $('[name="__RequestVerificationToken"]').val();
        var name = $('.register-user-panel .first-name').val();
        var email = $('.register-user-panel .email').val();
        var pwd = $('.register-user-panel .password').val();

        $.post(url, {
            __RequestVerificationToken: antiForgery,
            email: email, name: name, password: pwd,
            acceptUserAgreement: true
        },
        function (data) {
            // code executed when returning a successful action call
            var parsed = $.parseHTML(data);
            var hasErrors = $(parsed).find("[data-valmsg-summary]").text()
                .replace(/\n|\r/g, "").length > 0;

            if (hasErrors == true) {
                $(".register-user-panel").html(data);
                registerUserButton = $(".register-user-panel button").click(
                    onRegisterUserClick);
                registerUserCheckBox = $("#AcceptUserAgreement").click(
                    onToggleRegisterUserDisabledClick);
                $(".register-user-panel button").removeClass("disabled");
            }
            else {
                registerUserButton = $(".register-user-panel button").click(
                    onRegisterUserClick);
                registerUserCheckBox = $("#AcceptUserAgreement").click(
                    onToggleRegisterUserDisabledClick);
                location.href = '/Home/Index';
            }

        }).fail(function (xhr, status, error) {
            // Error code goes here
            alert('Post unsuccessful');
        });
    }
});