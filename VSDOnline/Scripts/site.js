$("#accordion").on("hidden.bs.collapse", function (e) {
    $(e.target).closest(".panel-default")
        .find(".panel-heading span")
        .removeClass("glyphicon glyphicon-minus")
        .addClass("glyphicon glyphicon-plus");
});
$("#accordion").on("shown.bs.collapse", function (e) {
    $(e.target).closest(".panel-default")
        .find(".panel-heading span")
        .removeClass("glyphicon glyphicon-plus")
        .addClass("glyphicon glyphicon-minus");
});
$(document).ready(function () {

    $("#jquery_jplayer_1").jPlayer({
        ready: function () {
            $(this).jPlayer("setMedia", {
                title: "Bubble",
                mp3: "../Audio/vsdsong.mp3"
            }).jPlayer("play");
        },
        swfPath: "~/Scripts",
        supplied: "mp3",
        wmode: "window",
        useStateClassSkin: true,
        autoBlur: false,
        smoothPlayBar: true,
        keyEnabled: true,
        remainingDuration: true,
        toggleDuration: true
    }).bind($.jPlayer.event.play, function () { // pause other instances of player when current one play
        $(this).jPlayer("pauseOthers");
    });
});
