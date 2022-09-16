function walking(steps, footprint, speed){
    let distance = steps * footprint;
    let speedInM = speed*1000/3600;
    let timeInS = distance/speedInM;
    let rest = (Math.floor(distance/500))*60;
    let totalTime = rest + timeInS;

    let seconds = (totalTime%60).toFixed(0);
    let minutes = Math.floor(totalTime/60);
    let hours = Math.floor(totalTime/3600)

    let formatedS = seconds < 10 ? `0${seconds}` : `${seconds}`;
    let formatedM = minutes < 10 ? `0${minutes}` : `${minutes}`;
    let formatedH = hours < 10 ? `0${hours}` : `${hours}`;

/*
    let time = new Date(0);

    time.setSeconds(totalTime)
    let timeString = time.toISOString().substring(11, 19);
 */
    console.log(`${formatedH}:${formatedM}:${formatedS}`);
}

walking(4000, 0.60, 5);
walking(2564, 0.70, 5.5);