function findMaxSequence(arr){
    var maxSequence = [];
    var tempSequence = [];
    tempSequence[0] = arr[0];
    var maxCount = 1;
    var tempCount = 1;
    
    if (arr.length == 1) {
        console.log(arr);
    }
    else {
        for (var i = 1; i < arr.length; i++) {
            
            if (arr[i] === arr[i - 1]) {
                tempCount++;
                tempSequence.push(arr[i]);
            }
            else if (arr[i] !== arr[i - 1]) {
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
        console.log(maxSequence);
    }
}
findMaxSequence([2, 1, 1, 2, 3, 3, 2, 2, 2, 1]);
findMaxSequence(['happy']);
findMaxSequence([2, 'qwe', 'qwe', 3, 3, '3']);
