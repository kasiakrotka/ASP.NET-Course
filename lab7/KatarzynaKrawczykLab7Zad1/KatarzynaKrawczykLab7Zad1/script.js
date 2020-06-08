//czas wygaśnięcia promocji
var date = new Date(2018, 09, 09, 0, 0, 0, 0);
//licznik dla zmiany koloru "FREE SHIPPING"
var counter = 0;
//licznik dla zmiany koloru dopisku do ceny "HOT!"
var counterPrice = 0;
//Ustawia nową datę na liczniku 
//napisane w oparciu o: https://www.w3schools.com/howto/howto_js_countdown.asp
function setNewTime()
{
    var now = new Date().getTime();
    var distance = date - now;
    if (distance < 0)
    { document.getElementById("counter").innerHTML = "EXPIRED";}
    else
    {
        var days = Math.floor(distance / (1000 * 60 * 60 * 24));
        var hours = Math.floor((distance % (1000 * 60 * 60 * 24)) / (1000 * 60 * 60));
        var minutes = Math.floor((distance % (1000 * 60 * 60)) / (1000 * 60));
        var seconds = Math.floor((distance % (1000 * 60)) / 1000);

        document.getElementById("counter").innerHTML =" "+days + "d " + hours + "h " + minutes + "m " + seconds + "s ";
    }
}
//zmienia kolor "FREE SHIPPING" w reklamie
function changeColor()
{
    if (counter % 2 == 0)
        document.getElementById("attention").style.color = "#FFFFFF";
    else
        document.getElementById("attention").style.color = "#e60073";

    counter++; 
}
//smienia kolor dopisku do ceny "HOT!"
function changeColorPrice()
{
    if (counterPrice % 2 == 0)
        document.getElementById("item-price-hot").style.color = "#e60073";
    else
        document.getElementById("item-price-hot").style.color = "#FFB6C1";

    counterPrice++;
}
//zmienia zdjęcie produktu na zdjęcie bluzy
function changeImageToSweatshirt()
{
    document.getElementById("item-photo").src = "Images/sweatshirt.png";
}
//zmienia zdjęcie produktu na zdjęcie t-shirtu
function changeImageToShirt() {
    document.getElementById("item-photo").src = "Images/t-shirt.png";
}

setNewTime()
setInterval(setNewTime, 1000)
setInterval(changeColor, 650)
setInterval(changeColorPrice, 650)