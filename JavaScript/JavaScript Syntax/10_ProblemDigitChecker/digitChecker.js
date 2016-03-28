function checkDigit(number){
    number = number % 1000;
    number = parseInt(number / 100);

    if (number == 3) {
        console.log('true');
    } else {
        console.log('false');
    }
}

checkDigit(1235);
checkDigit(25368);
checkDigit(123456);