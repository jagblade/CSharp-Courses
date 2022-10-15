function heroicInventory (arr){
    let result = [];

    for (const iteration of arr) {
        let [name,level,items] = iteration.split(' / ');
        level = Number(level);

        items = items ? items.split(', '):[];
        obj = returnObj([name,level,items])
        result.push(obj);    
    }
    function returnObj(data){
        obj = {
        };
        obj.name = data[0];
        obj.level = data[1];
        obj.items = data[2];
        return obj
    }
    console.log(JSON.stringify(result))
}

heroicInventory(
    ['Isacc / 25 / Apple, GravityGun',
'Derek / 12 / BarrelVest, DestructionSword',
'Hes / 1 / Desolator, Sentinel, Antara']
)