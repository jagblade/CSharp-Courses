function calorieObject(arr){
    obj = {};

    for (let i = 0; i < arr.length; i+=2) {
        let prop = arr[i];
        let value = arr[i+1];
        obj[prop] = Number(value);
    }
    console.log(obj)
}

calorieObject(['Yoghurt', '48', 'Rise', '138', 'Apple', '52'])