function solve (input){

    var trueInt, sumInt;
    var gold, silver, bronze;
    sumInt=0;

    for (var i=0; i<input.length; i++){
        trueInt = input[i].split(" ");

        function isPositiveInteger(n) {
            return n >>> 0 === parseFloat(n);
        }
        if(trueInt[0].toUpperCase() == 'COIN' && isPositiveInteger(trueInt[1]) ){
            //console.log(trueInt[0]+'-'+trueInt[1]);
            sumInt += parseInt(trueInt[1]);
            //console.log(sumInt);

        }
    }
    //console.log(sumInt);
    gold = sumInt / 100;
    console.log('gold : ' + parseInt(gold));
    silver = sumInt % 100;
    silver = silver / 10;
    console.log('silver : ' + parseInt(silver));
    bronze = sumInt % 10;
    console.log('bronze : ' + parseInt(bronze));

}

solve(['Coin 1','coin 2','coin 5','coin 10','coin 20','coin 50','coin 100','coin 200','coin 500','cigars 1']);