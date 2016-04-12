var player;

function onYouTubePlayerAPIReady() {
    // create the global player from the specific iframe (#video)
    player = new YT.Player('siteaudiosong', {
        events: {
            // call this function when player is ready to use
            'onReady': onPlayerReady,
            'onStateChange': onYouTubePlayerStateChange
        }
    });
}

function onPlayerReady(event) {

    //player.addEventListener("onStateChange", "onYouTubePlayerStateChange");

    //// bind events
    var imgaudioplapause = document.getElementById("imgaudioplaypause");
    imgaudioplapause.addEventListener("click", function () {

        var state = player.getPlayerState();
        if (state === 1) {
            $("imgaudioplaypause").removeClass();
            $("imgaudioplaypause").addClass("imgaudioplaypause play pull-right");
            player.pauseVideo();
            //document.getElementById('imgaudioplaypause') = 'play';
        }
        else if (state === 2) {
            $("imgaudioplaypause").removeClass();
            $("imgaudioplaypause").addClass("imgaudioplaypause pause pull-right");
            player.playVideo();
            //document.getElementById('imgaudioplaypause').className = 'pause';
        }
    });

    //var pauseButton = document.getElementById("pause-button");
    //pauseButton.addEventListener("click", function () {
    //    player.pauseVideo();
    //});

}

//var player = null;
//var lobbyAudio = null;

//function onYouTubePlayerReady(playerapiid) {
//    player = document.getElementById(playerapiid);
//    lobbyAudio = document.getElementById('lobby-audio');
////    player.addEventListener("onStateChange", "onYouTubePlayerStateChange");
//}

function onYouTubePlayerStateChange(state) {
    switch (state.data) {
        case 1:  // playing
            $("imgaudioplaypause").removeClass();
            $("imgaudioplaypause").addClass("imgaudioplaypause pause pull-right");
            //document.getElementById('imgaudioplaypause').className = 'pause';
            //lobbyAudio.pause();
            break;
        case 0:  // ended
        case 2:  // paused
            $("imgaudioplaypause").removeClass();
            $("imgaudioplaypause").addClass("imgaudioplaypause play pull-right");
            //document.getElementById('imgaudioplaypause').className = 'play';
            break;
    }
}