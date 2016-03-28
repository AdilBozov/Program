function convertKWtoHP(capacityKW){
    var capacityHP = capacityKW / 0.745699872;
    return capacityHP.toFixed(2);
}

console.log(convertKWtoHP(75));
console.log(convertKWtoHP(150));
console.log(convertKWtoHP(1000));