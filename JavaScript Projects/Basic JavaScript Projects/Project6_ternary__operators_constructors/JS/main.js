function results() {
  var age = document.getElementById("Age").value;
  var message = (age < 18) ? "too young to vote":"old enough to vote!"; //asigning message a value based on a ternary condition.
  var Height = document.getElementById("Height").value; //grabbing the value for Height from document.
  var canRide = ((Height < 52) ?"You are too short to ride, and ":"You are tall enough to ride, and "); //asigning canRide a value based on a ternary condition.
  document.getElementById("Result").innerHTML = canRide + message; //filling in the result paragraph with our results.
}
//grabbing age and height values from document, using them each in a ternary operation, and displaying a message to the page based on results.

function coffee() {
  this.size = document.getElementById("Size").value;
  this.shots = document.getElementById("Shots").value;
  this.drink = document.getElementById("Drink").value;
  this.milk = document.getElementById("Milk").value;
}
//defining a coffee constructor with 4 key:value pairs.

function nested() {
  var order = new coffee()
  document.getElementById("Nested_Function").innerHTML = (document.getElementById("Age").value < 16) ? "You're a bit young to be a Tech Academy instructor, and also for coffee, have a steamer.":ready()
  function ready () {
     return "I've got a " + order.size + " " + order.shots + " " + order.drink + " with " + order.milk + " for " + document.getElementById("Name").value + " on the bar!"
  }
}
//Using a nested function to construct a coffee object and return a value based on that object to the higher function, which uses it to fill in the "Nested_Function" paragraph.
