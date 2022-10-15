function carFactory(car) {
    let newCar = {
        model:"",
        engine:{},
        carriage:{},
        wheels: [],
    };
    newCar.model = car.model;

    if (car.power <= 90) {
        newCar.engine = { power: 90, volume: 1800 }
    } else if (car.power <= 120) {
        newCar.engine = { power: 120, volume: 2400 }
    } else {
        newCar.engine = { power: 200, volume: 3500 }
    }

    if (car.carriage === 'hatchback') {
        newCar.carriage = { type: 'hatchback',color: car.color}
    } else {
        newCar.carriage = { type: 'coupe', color: car.color}
    }   

    if(car.wheelsize%2 === 0){
        let wheel = car.wheelsize-1;
        newCar["wheels"] = [wheel,wheel,wheel,wheel]
    }else{
        let wheel = car.wheelsize;
        newCar["wheels"] = [wheel,wheel,wheel,wheel]
    }

    
    return newCar
}


console.table(carFactory(
    {
        model: 'VW Golf II',
        power: 90,
        color: 'blue',
        carriage: 'hatchback',
        wheelsize: 14
    }

))