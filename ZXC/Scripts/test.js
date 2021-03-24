let num = 0;

let Paths = ['https://localhost:44361/Video/1.mp4', 'https://localhost:44361/Video/2.mp4',
    'https://localhost:44361/Video/3.mp4', 'https://localhost:44361/Video/4.mp4',
    'https://localhost:44361/Video/5.mp4', 'https://localhost:44361/Video/6.mp4', 'https://localhost:44361/Video/7.mp4', 'https://localhost:44361/Video/8.mp4', 'https://localhost:44361/Video/9.mp4']

var video;
var i;
addEventListener('load', function () {
    video = document.getElementById('player');
})

addEventListener('click', function () {
    //alert(Paths[num]);
    num++;
    if (num == 9) {
        num = 0;
    }
    
    video.pause();

    video.setAttribute('src', Paths[num]);

    video.load();

    video.play();

    //alert(Paths[num]);
}); 