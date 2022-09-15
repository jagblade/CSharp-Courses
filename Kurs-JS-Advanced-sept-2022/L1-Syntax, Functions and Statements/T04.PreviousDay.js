function solve(year,month,date){
    let currentDate = new Date(year,month-1,date-1);

    console.log(`${currentDate.getFullYear()}-${currentDate.getMonth()+1}-${currentDate.getDate()}`)
    
}


solve(2016, 9, 30);
solve(2016, 10, 1);