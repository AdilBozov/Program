function findPalindromes(str) {
    var strArr = str.toLowerCase().split(/[^A-z]+/);
    var palindromes = [];
    for (var word in strArr) {
        var pal = true;
        
        if (strArr[word].length == 1) {
            palindromes.push(strArr[word]);
        }
        else {
            for (var i = 0, j = strArr[word].length - 1; i < Math.floor(strArr[word].length / 2); i++, j--) {
                if (strArr[word].charAt(i) != strArr[word].charAt(j)) {
                    pal = false;
                    break;
                }
            }
            if (pal)
                palindromes.push(strArr[word]);
        }
    }
    palindromes.splice(palindromes.length - 1);
    
    console.log(palindromes);
}

findPalindromes("There is a man, his name was Bob.");
findPalindromes("There is a man, hooh,  his ahoha! name was Bob.");