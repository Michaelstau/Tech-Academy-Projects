function changeText() { //declair a function
  var here = "in the office", now = "2:34 pm"; //assign two variables
  document.getElementById("text").innerHTML = "I want you " + here + " by " + now; //concatenate two variables (and some text), and display them in "text" paragraph.
}
var sentence = "I am learning"; //assign a global variable

function addStuff() {
  sentence += " so much!"; //concatenate " so much!" to sentence variable
  document.getElementById("concatenate").innerHTML = sentence; //display variable in the  paragraph.
}
