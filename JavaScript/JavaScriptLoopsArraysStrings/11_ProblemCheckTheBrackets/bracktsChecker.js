function checkerBrackets(str){
    var sumLeft = 0;
    var sumRight = 0;

    for (var i = 0; i < str.length; i +=1){
        if (str.charAt(i) == '(') {
            sumLeft += 1;
        } else if (str.charAt(i) == ')') {
            sumRight += 1;
        }
    }
    if (sumLeft == sumRight) {
        console.log('correct');
    } else {
        console.log('incorrect');
    }
}

checkerBrackets('( ( a + b ) / 5 – d )');
checkerBrackets(') ( a + b ) )');
checkerBrackets('( b * ( c + d *2 / ( 2 + ( 12 – c / ( a + 3 ) ) ) )');