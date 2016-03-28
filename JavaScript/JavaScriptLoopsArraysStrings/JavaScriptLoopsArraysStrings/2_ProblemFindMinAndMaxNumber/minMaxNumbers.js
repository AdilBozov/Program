function minMaxNumbers(arr){
    arr.sort(function (a, b) { return a > b });
    var max = Math.max.apply(Math, arr);
    console.log('Min -> ' + arr[0]);
    console.log('Max -> ' + max);
}

minMaxNumbers([1, 2, 1, 15, 20, 5, 7, 31]);
minMaxNumbers([2, 2, 2, 2, 2]);
minMaxNumbers([500, 1, -23, 0, -300, 28, 35, 12]);