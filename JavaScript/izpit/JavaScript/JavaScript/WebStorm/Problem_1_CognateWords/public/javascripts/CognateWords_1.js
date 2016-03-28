function solve(input){
    var text = input[0];
    var words =text.split(/[^A-Za-z]+/);
    words= words.filter((Boolean)); //maha prazen string v masiv ako ima takyf
    //words= words.filter(function (w) {return w!==''}); //maha prazen string v masiv ako ima takyf
    var output = [];

    for (var a = 0; a < words.length; a++) {
        for (var b = 0; b < words.length; b++) {
            for (var c = 0; c < words.length; c++) {
                if(a!==b){
                    var check = words[a] + words[b] === words[c];

                    if(check){
                        var congnateWord=words[a] + '|' + words[b] + '=' + words[c];
                        if(output.indexOf(congnateWord) < 0){
                            output.push(congnateWord);
                        }
                    }
                }
                
            }
            
        }
        
    }
    if (output.length < 1){
        console.log('No');
    } else{
        console.log(output);
    }
}

solve(['Uni(lo,.ve=I love SoftUni (Soft)']);
