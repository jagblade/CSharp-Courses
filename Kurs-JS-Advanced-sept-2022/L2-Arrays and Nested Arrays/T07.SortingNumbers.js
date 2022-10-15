function sortingNumbers(arr){
    let res = [];
    let sortedArr = arr.sort((a,b) => a - b);

    while (sortedArr.length != 0) {
        res.push(sortedArr.shift(),sortedArr.pop());
    }
    console.log(res);
    return res;

}

sortingNumbers([1, 65, 3, 52, 48, 63, 31, -3, 18, 56])