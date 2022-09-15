function sameNumber(num){
    let stringNum = num.toString();
    let isSame = true;
    let sum = Number(stringNum[0]);
    let first = Number(stringNum[0]);

    for (let i = 1; i < stringNum.length; i++) {
        let checked = Number(stringNum[i]);
        if (first !== checked) {
            isSame = false; 
        } 

        sum += Number(stringNum[i]);

    }
    console.log(isSame);
    console.log(sum);
}


sameNumber(2222222);
sameNumber(1234);