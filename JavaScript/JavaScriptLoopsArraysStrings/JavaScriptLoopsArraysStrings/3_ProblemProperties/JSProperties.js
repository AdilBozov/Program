function docProperties() {
    var pro = [];
    for(var prop in document){
        pro.push(prop);
    }
    pro.sort();
    document.getElementById("output").innerHTML = pro.join('<br>');
}

docProperties();