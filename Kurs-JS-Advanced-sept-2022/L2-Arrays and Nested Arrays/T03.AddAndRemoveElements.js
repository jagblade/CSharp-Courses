function addAndRemoveElements(cmdArray){
    let arr = [];
    let counter = 1;

    for (let i = 0; i < cmdArray.length; i++) {
        const element = cmdArray[i];
        if (element === `add`) {
            arr.push(counter);
        }
        else if (element === `remove`) {
            arr.pop();
        }
        counter++;
    }

    if (arr.length < 1) {
        console.log(`Empty`)
    }else{
        console.log(arr.join("\n"))
    }
}


addAndRemoveElements(['add', 
'add', 
'add', 
'add']
)
console.log("--------------")
addAndRemoveElements(['add', 
'add', 
'remove', 
'add', 
'add']
)
console.log("--------------")
addAndRemoveElements(['remove', 
'remove', 
'remove']
)
