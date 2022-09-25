function print(arr,num){
    let result = [];

    for (let i = 0 ; i < arr.length; i+=num) {
        result.push(arr[i]);
        
    }

    return result;
}

print(['5', 
'20', 
'31', 
'4', 
'20'], 
2
)
print(['dsa',
'asd', 
'test', 
'tset'], 
2
)
print(['1', 
'2',
'3', 
'4', 
'5'], 
6
)