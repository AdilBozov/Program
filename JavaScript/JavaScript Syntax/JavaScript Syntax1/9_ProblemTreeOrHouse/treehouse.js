function treeHouseCompare(a, b){
    var house = (a * a) + (a * a * 2) / 6;
    var tree = (b * b / 3) + (Math.pow((2 * b) / 3, 2) * Math.PI);

    if (house > tree) {
        return 'house/' + house.toFixed(2);
    } else {
        return 'tree/' + tree.toFixed(2);
    }

    if (house == tree) {
        return 'equal/' + tree.toFixer(2);
    }
}

console.log(treeHouseCompare(3, 2));
console.log(treeHouseCompare(3, 3));
console.log(treeHouseCompare(4, 5));