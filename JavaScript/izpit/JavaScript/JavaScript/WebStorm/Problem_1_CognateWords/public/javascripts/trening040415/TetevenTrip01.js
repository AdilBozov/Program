
function evalueate(array){

    var carModel, fuleTypr, road, luggageWelghl;
    var currentLine;
    var fuleConsumtion, totalConsumption;


    for (var i in array){
        currentLine = array[i].split(" ");
        console.log(currentLine);

         carModel = currentLine[0];
         fuleTypr = currentLine[1];
         road = Number(currentLine[2]);
         luggageWelghl = Number(currentLine[3]);

        fuleConsumtion = 10;
        switch (fuleTypr) {
            case "gas":
                fuleConsumtion *=1.2;
                break;
            case "diesel":
                fuleConsumtion *=0.8;
                break;
            case "petrol":
            default :
                break
        }

        fuleConsumtion += luggageWelghl * 0.01;

        if ( road == 1){
            totalConsumption = fuleConsumtion * 110/100;
            totalConsumption += fuleConsumtion * 0.3 * 10/100;

        }
        else {
            totalConsumption = fuleConsumtion * 95/100;
            totalConsumption += fuleConsumtion * 0.3 * 30/100;
        }
        totalConsumption= Math.round(totalConsumption);
        console.log(carModel + " " + fuleTypr + " " + road + " " +totalConsumption);
    }
}

var input = ['BMW petrol 1 320.5',
    'Golf petrol 2 150.75',
    'Lada gas 1 202',
    'Mercedes diesel 2 312.54'];

evalueate(input);