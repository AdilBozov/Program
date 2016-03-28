function findMaxSequence(arr) {
    var maxSequence = [];
    var tempSequence = [];
    tempSequence[0] = arr[0];
    var maxCount = 1;
    var tempCount = 1;
    
    for (var i = 1; i < arr.length; i++) {
        
        if (arr[i] > arr[i - 1]) {
            tempCount++;
            tempSequence.push(arr[i]);
        }
        else if (arr[i] <= arr[i - 1]) {
            if (tempCount >= maxCount) {
                maxCount = tempCount;
                tempCount = 1;
                maxSequence = [];
                maxSequence = tempSequence;
                tempSequence = [];
                tempSequence[0] = arr[i];
            }
            else {
                tempCount = 1;
                tempSequence = [];
                tempSequence[0] = arr[i];
            }
        }
    }
    
    if (tempCount >= maxCount) {
        maxSequence = [];
        maxSequence = tempSequence;
    }
    
    if (maxCount == 1) {
        console.log("no");
    }
    else {
        console.log(maxSequence);
    }
}

findMaxSequence([3, 2, 3, 4, 2, 2, 4]);
findMaxSequence([3, 5, 4, 6, 1, 2, 3, 6, 10, 32]);
findMaxSequence([3, 2, 1]);