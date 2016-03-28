function findMostFredNumber(arr){
    var number = 0;
    var sum = 0;
    var maxSum = 0;
    for (var i = 0; i < arr.length; i += 1) {
        for (var j = 0; j < arr.length; j += 1) {
            if (arr[i] == arr[j]) {
                sum += 1;
            }
        }
        if (sum > maxSum) {
            maxSum = sum;
            number = arr[i];
        }
        sum = 0;
    }
    console.log(number + ' (' + maxSum + ' times)');
}

findMostFredNumber([4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3]);
findMostFredNumber([2, 1, 1, 5, 7, 1, 2, 5, 7, 3, 87, 2, 12, 634, 123, 51, 1]);
findMostFredNumber([1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13]);
