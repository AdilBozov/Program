function ewoksFans(input) {
    var year = new Array;
    var month = new Array;
    var day = new Array;
    var sum = 0;
    var yearMax = 0
    var yeareIndexMax = 0;
    var yearMim = 0
    var yeareIndexMin = 0;
    var pattern = /(\d{2})\.(\d{2})\.(\d{4})/;
    for (var i = 0; i < input.length; i++) {
        var date = input[i].split('.');
        day[i] = parseInt(date[0]);
        month[i] = parseInt(date[1]);
        year[i] = parseInt(date[2]);
    }
    for (var i = 0; i < year.length; i++) {
        if (year[i] < 1900 || year[i] > 2015) {
            sum = sum + 1;
            if (sum == year.length) {
                console.log('No result');
            }
        } else if (year[i] > year[i + 1]) {
            yearMax = year[i]
            yeareIndexMax = i;
        } else if (year[i] < year[i + 1]) {
            yearMim = year[i]
            yeareIndexMin = i;
        }
       
    }
    if (yearMax != 0 && yearMim != 0) {
        var printMax = new Date(input[yeareIndexMax].replace(pattern, '$3-$2-$1'));
        var printMin = new Date(input[yeareIndexMin].replace(pattern, '$3-$2-$1'));
        console.log('The biggest fan of ewoks was born on ' + printMax);
        console.log('The biggest hater of ewoks was born on ' + printMin);
    } else {
        var printMax = new Date(input[yeareIndexMax].replace(pattern, '$3-$2-$1'));
        console.log('The biggest fan of ewoks was born on ' + printMax);
    }
}
ewoksFans(['22.03.2000']);