function numbers(x,y){
    while(y){
        var t = y;
        y = x%y;
        x= t;

       

    }
    console.log(x)
}

numbers(15,5)
numbers(2154, 458)