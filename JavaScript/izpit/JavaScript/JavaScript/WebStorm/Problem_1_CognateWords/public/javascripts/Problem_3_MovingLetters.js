function solve(input){
    var words = input[0].split(' ');

    var maxLength =0;
    for (var i = 0; i < words.length; i++) {
       if(words[i].length > maxLength){
           maxLength = words[i].length;
       }
    }
    var letters ='';
    for (var i = 0; i < words.length; i++) {
        words[i] = words[i].split('');

    }
    for (var lett = 0; lett < maxLength; lett++) {
        for (var index = 0; index < words.length; index++) {
           if(words[index].length > 0){
               letters += words[index].pop();// pop() vzima posledna stoinost ot masiva i ni q vryshta kato rezultata i q iztriva
           }

        }
        
    }
    letters = letters.split('');
    for (var i = 0; i < letters.length; i++) {
        var numMuves;
        var newPosition;
        numMuves=letters[i].toLocaleLowerCase().charCodeAt(0)-96;//charCodeAt() - vzima stoinosta na simvola ot aski tablicata
        newPosition = (numMuves + i) % letters.length;
        var currChar = letters[i];
        letters.splice(i,1);
        letters.splice(newPosition,0,currChar);
    }
    console.log(letters.join(''));
}

solve(['Fun exam right']);
