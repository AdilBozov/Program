function divisionBy3(number){
    var sum = 0;
    var numSave = number;
    while (number > 0) {
        sum = sum + (number % 10);
        number = parseInt(number / 10);
    }

    if (sum % 3 == 0) {
        console.log(numSave + '- the number is divided by 3 without remainder');
    } else {
        console.log(numSave + '- the number is nod divided by 3 without remainder');
    }
}
divisionBy3(12);
divisionBy3(188);
divisionBy3(591);