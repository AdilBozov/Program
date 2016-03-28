function solve (input){
    var numbers = input[0].split(/[ ()]+/);
    numbers = numbers.filter(Boolean).map(Number);// map(Number) parsva celiq string kym chisla
    var counter = 1;
    var maxCounter = 1;

    for (var i = 0; i < numbers.length - 1; i++) {  //itar ->for cikyl

        if(numbers[i] == 0 && i>0){
            if(maxCounter < counter){
                maxCounter = counter;
            }
            numbers[i]= numbers[i-1] + 1;
        }
        var isOisOddCurrentdd = numbers[i] % 2 !== 0;
        var isOddNext = numbers[i+1] % 2 !== 0;
        if(!isOisOddCurrentdd && numbers[i+1] === 0){
            isOddNext = !isOisOddCurrentdd;
        }
        if(isOisOddCurrentdd !== isOddNext || numbers[i] == 0){
            counter ++;
            if(maxCounter < counter){
                maxCounter = counter;
            }
        } else{
            counter = 1;
        }
        isOisOddCurrentdd = isOddNext;
    }

    console.log(maxCounter);
}

solve(['(3) (22) (-18) (55) (44) (3) (21)']);