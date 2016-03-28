function reverseString(str){
    var revStr = '';
    for(var i = str.length; i >= 0; i--){
        revStr = revStr + str.charAt(i);
    }
    console.log(revStr);
}
reverseString('sample');
reverseString('softUni');
reverseString('java script');