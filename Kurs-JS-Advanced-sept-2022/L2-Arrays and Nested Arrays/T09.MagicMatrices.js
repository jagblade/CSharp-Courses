function magicMatrices(matrix) {
    for (let i = 0; i < matrix.length - 1; i++) {
        let sumRowOne = matrix[i].reduce((acc, el) => acc + el);
        let sumRowTwo = matrix[i + 1].reduce((acc, el) => acc + el);

        let sumColOne = 0;
        let sumColTwo = 0;

        for (let col = 0; col < matrix.length; col++) {
            sumColOne += matrix[i][col];
            sumColTwo += matrix[i][col];

        }
        if (sumRowOne !== sumRowTwo || sumColOne !== sumColTwo) { return false }
    }

    return true
}

console.log(
    magicMatrices(
        [[4, 5, 6],
        [6, 5, 4],
        [5, 5, 5]]
    ))
console.log(
    magicMatrices(
        [[1, 0, 0],
        [0, 0, 1],
        [0, 1, 0]]

    ))
console.log(
    magicMatrices(
        [[11, 32, 45],
        [21, 0, 1],
        [21, 1, 1]]
    ))
