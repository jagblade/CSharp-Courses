function radar(speed,loc){
    let limits =["motorway", 130,"interstate", 90,"city", 50,"residential",20];
    const isLoc = (element) => loc == element;

    let currSpeedLimit = limits[(limits.findIndex(isLoc) + 1)];

    if (speed <= currSpeedLimit) {

        console.log(`Driving ${speed} km/h in a ${currSpeedLimit} zone`)
        
    } else {
        let exess = speed - currSpeedLimit;
        let status;

        if (exess <= 20) {
            status = "speeding"
        } else if (exess <= 40) {
            status = "excessive speeding";
        } else {
            status = "reckless driving";
        }
        console.log(`The speed is ${exess} km/h faster than the allowed speed of ${currSpeedLimit} - ${status}`)
    }
}


radar(40,"city");
radar(21, 'residential')
radar(120, 'interstate')
radar(200, 'motorway')