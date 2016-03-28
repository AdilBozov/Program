function solve(input){
    var numbers = [];
    for (var i = 0; i<input.length; i++){
        numbers[i] = Number(parseFloat(input[i]).toFixed(2));
    }
    console.log('<table>');
    console.log('<tr><th>Price</th><th>Trend</th></tr>');
    console.log('<tr><td>' + numbers[0].toFixed(2) + '</td><td><img src="fixed.png"/></td></tr>');
    var image = 'fixed'

    for (var j = 1; j<numbers.length; j++){
        if (numbers[j] < numbers[j-1]){
            image = 'down'
        } else if (numbers[j] > numbers[j-1]){
            image = 'up'
        } else {
            image = 'fixed';
        }
        console.log('<tr><td>' + numbers[j].toFixed(2) + '</td><td><img src=\"' + image + '.png\"/></td></tr>');
    }


    console.log('</table>');
}

solve(["36.333",
        "36.5",
        "37.019",
        "35.4",
        "35",
        "35.001",
        "36.225"]);
