function solve(input){

    function rute1 (fuel){
        fuelConsumation = (luggage*0.01)+ fuel;
        extraConsumation = 110 * (fuelConsumation/100);
        fuelConsumation = 0.3 * fuelConsumation;
        fuelConsumation = 10*(fuelConsumation/100);
        result = extraConsumation + fuelConsumation;
        console.log(mas[0]+ ' ' + mas[1] + ' ' + parseInt(mas[2]) + ' ' +parseInt(result.toFixed(0)));
    }

    function rute2 (fuel){
        fuelConsumation = (luggage*0.01)+ fuel;
        extraConsumation = 95 * (fuelConsumation/65);
        fuelConsumation = 0.3 * fuelConsumation;
        fuelConsumation = 30*(fuelConsumation/100);
        result = extraConsumation + fuelConsumation;
        console.log(mas[0]+ ' ' + mas[1] + ' ' + parseInt(mas[2]) + ' ' +parseInt(result.toFixed(0)));

    }

    var fuel;
    var route;
    var luggage;
    var i;
    for ( i = 0; i < input.length; i++) {
        var mas = input[i].split(' ');
        fuel = mas[1];
        route = Number(mas[2]);
        luggage = Number(mas[3]);
        var fuelConsumation;
        var extraConsumation;
        var result;


        if (route === 1) {
            if (fuel === 'gas') {
                rute1(12)
            } else if (fuel === 'petrol') {
                rute1(10)
            } else if (fuel === 'diesel') {
                rute1(8)
            }
        } else{
            if (fuel === 'gas') {
                rute2(7.8);

            } else if (fuel === 'petrol') {
                rute2(6.5);

            } else if (fuel === 'diesel') {
                rute2(4.9);

            }
        }

    }

}

solve([
    'BMW petrol 1 320.5',
    'Golf petrol 2 150.75',
    'Lada gas 1 202',
    'Mercedes diesel 2 312.54'
])
