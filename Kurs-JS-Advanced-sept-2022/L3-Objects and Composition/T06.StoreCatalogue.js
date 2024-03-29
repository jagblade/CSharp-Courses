function storeCatalogue(arr) {
    let result = {};

    for (const obj of arr.sort((a, b) => a.localeCompare(b))) {

        let [product, price] = obj.split(' : ');
        price = Number(price);

        let firstLetter = product[0];
        let object = { product, price };

        if (!result[firstLetter]) {
            result[firstLetter] = [];
        }
        result[firstLetter].push(object);
    }

    for (const item of Object.keys(result)) {
        console.log(item);
        for (const pr of result[item]) {
            console.log(`  ${pr.product}: ${pr.price}`);
        }
    }
}

storeCatalogue(
    [
        'Appricot : 20.4',
        'Fridge : 1500',
        'TV : 1499',
        'Deodorant : 10',
        'Boiler : 300',
        'Apple : 1.25',
        'Anti-Bug Spray : 15',
        'T-Shirt : 10'
    ])