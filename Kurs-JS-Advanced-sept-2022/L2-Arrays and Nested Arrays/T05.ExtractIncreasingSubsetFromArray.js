function extractIncreasingSubsetFromArray(arr){
    let res = [];
    let big = arr.shift();
    res.push(big);
    for (const el of arr) {
        if (el >= big) {
            res.push(el);
            big = el;
            
        }
    }
    return res;
    
}

extractIncreasingSubsetFromArray([1, 
    3, 
    8, 
    4, 
    10, 
    12, 
    3, 
    2, 
    24]
    )
