function results() {
  var age = document.getElementById("Age").value;
  var message = (age < 18) ? "too young to vote":"old enough to vote!";
  var Height = document.getElementById("Height").value;
  var canRide = ((Height < 52) ?"You are too short to ride, and ":"You are tall enough to ride, and ");
  document.getElementById("Result").innerHTML = canRide + message;
}

function coffee() {
  this.size = document.getElementById("Size").value;
  this.shots = document.getElementById("Shots").value;
  this.drink = document.getElementById("Drink").value;
  this.milk = document.getElementById("Milk").value;
}

function nested() {
  var order = new coffee()
  document.getElementById("Nested_Function").innerHTML = (document.getElementById("Age").value < 16) ? "You're a bit young to be a Tech Academy instructor, and also for coffee, have a steamer.":ready()
  function ready () {
     return "I've got a " + order.size + " " + order.shots + " " + order.drink + " with " + order.milk + " for " + document.getElementById("Name").value + " on the bar!"
  }
}
