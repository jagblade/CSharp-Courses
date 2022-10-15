function sortAnArrayby2Criteria(arr){
   return arr.sort().sort((a,b) => a.length - b.length ).join("\n")

}

console.log(sortAnArrayby2Criteria(['alpha', 
'beta', 
'gamma'])
)
console.log("----------------")
console.log(sortAnArrayby2Criteria(['Isacc', 
'Theodor', 
'Jack', 
'Harrison', 
'George']
))