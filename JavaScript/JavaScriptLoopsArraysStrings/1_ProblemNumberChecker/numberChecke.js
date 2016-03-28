function printNubers(number) {
    var sum = '';
    if (number > 0){
        for(var i = 1; i <= number; i++){
            if ((i % 4) != 0 && (i % 5) != 0) {
                sum = sum + i + ', ';
            }
        }    
    } else {
        console.log('no');
    }
    console.log(sum);
}

printNubers(20);
printNubers(-5);
printNubers(13);