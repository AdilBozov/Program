function solve (input){

    function isRakiyaNumber(number){

        var pattern = /(\d{2})\d*\1/g;
        if(number.toString().match(pattern)){
            return true;
        }

        return false;
    }

    var start = Number(input[0]);
    var end = Number(input[1]);
    var number;

    console.log('<ul>');
    for (var number = start; number <= end; number++) {
        if (isRakiyaNumber(number)){
            console.log("<li><span class=\'rakiya\'>" + number + "</span><a href=\"view.php?id=" + number +">View</a></li>");
        } else{
            console.log("<li><span class='num'>" + number + "</span></li>")
        }

    }
    console.log('</ul>');
}

solve(['11210', '11215'])

//(\d{2}).*\1 ili (\d{2})\d*\1 - machvame chisla dvoiki koito se povtarqt pptimerno 3235632 macva ni 32
// d - macva vsichki chisla
//{2} otbelqzvame kolko chisla da machva s slucheq - dvoikite chisla koito da n machva
//{2, 6} cifri v intervala ot 2 do 6 chisla
//{2,} cifri ot 2 ili poveche
//. edin ili poveche simvoli
//() - taka markirae grupi za po lesno dostypvane
// \1 koq grupa da ni vzema
//* da se povtarq edin ili poveche pyti