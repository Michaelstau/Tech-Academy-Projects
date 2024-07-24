var V = "The \"variable\" "; //assigns a value to a variable
document.write(V + " is alive! "); //concatinates and writes the result on the page
var D = V + "is dead. "; //concatinates, and assigns a value to a variable
window.alert(D); //makes an alert pop up when visiting page
var some_text = "It worked!"

function button_function() {
  document.getElementById("the_button").innerHTML = some_text // changes text on the_button
}

function change_function() {
  document.getElementById("the_button").innerHTML = "click!"
}

var Sent1 = "This is the beginning ot the string", Sent2 = " and this is the end of the string" //assigns 2 variable

var megaVariable = Sent1 + Sent2 //concatinates two variables into a megaVariable
document.write(megaVariable) //writes the megaVariable to the page
