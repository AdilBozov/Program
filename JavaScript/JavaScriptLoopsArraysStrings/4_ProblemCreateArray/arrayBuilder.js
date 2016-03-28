function createArray(n){
    
    var arr = new Array(n);

    for (var i = 0; i < arr.length; i++) {
        arr[i] = i * 5;
    }
    console.log(arr);
}

createArray(20);