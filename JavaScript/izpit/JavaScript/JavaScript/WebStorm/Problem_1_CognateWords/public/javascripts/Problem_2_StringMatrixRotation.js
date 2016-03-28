function stringMatrixRotation(input){

    function loaMatrix (input){
        var matrix =[];
        var maxLength = 0;
        for (var i = 0; i < arguments.length; i++) {
            if(input[i].length > maxLength){
            maxLength = input[i].length;
            }
        }

        for (var i = 0; i < input.length; i++) {
            var row = input[i] + Array(maxLength - input[i].length + 1).join(' ');
            matrix.push(row.split(''));
        }
    }

    function rotateMatrix90(matrix){
        var newMatrix = [];
        var row, newRow;
        var col , newCol;
        for ( col = 0; col < matrix[0].length; col++) {
            newRow = col;
            newMatrix[newRow] = [];
            newCol = matrix.length - row;
            for ( row = matrix.length - 1; row >= 0; row--) {
                newCol = matrix.length -1 - row;
                newMatrix[newRow].push(matrix[row][col]);

            }

        }
        return newMatrix;
    }

    function printMatrix(matrix){
        for (var i = 0; i < matrix.length; i++) {
           console.log(matrix[i].join(''));

        }
    }

    var degAsString = input[0].match(/\d+/);
    var deg = Number(degAsString[0]);
    var matrix= [];
    var turne = deg % 360 / 90;


    matrix = loaMatrix(input);
    for (var i = 0; i < turne; i++) {

        matrix = rotateMatrix90(matrix);
    }

   printMatrix (matrix);

}

stringMatrixRotation([
    'Rotate(90)',
    'hello',
    'softuni',
    'exam'
    ])

//reverse obryshta rezultata a b c > c b a