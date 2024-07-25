var worldlyVariable = "present"; //assigning a global variable.

function smallTown() {
  var smallTownVariable = "local"; //assigning a local variable.
}

function meeting() {
  console.log(smallTownVariable);
  /* document.getElementById("meeting").innerHTML = "worldlyVariable is " + worldlyVariable + ", smallTownVariable's location is " + smallTownVariable; */

} //defining a function that would have used a variable local to smallTown, and using console.log to to troubleshoot the problem.

function coffeeTime() {
  if (new Date().getHours() < 14) {
    document.getElementById("Coffee").innerHTML = "No, let's grab an espresso!";
  }
  else {
    document.getElementById("Coffee").innerHTML = "Yeah, I'd be up all night if I had one now.";
  }
} //defining a function that checks to see if the time is earlier than 2:00pm and asks the user to either get coffee, or not to.

function haunted() {
  var concern = document.getElementById("No")
  var haunt =document.getElementById("Haunted")
  if (concern.checked) {
    haunt.innerHTML = "Get out! This place is haunted!!!"
  }
  else {
    haunt.innerHTML = "Relax, it's just the wind."
  }
} //defining a function that sets variables for the "no" checkbox, and "haunted" paragraph. Then checks to see if the checkbox is checked, and alerts the user to either escape the building or relax depending on an if, else logic statement.

function Time_function() {
  var Time = new Date().getHours();
  var Reply
  if (Time < 12 == Time > 0) {
    Reply = "It is morning time!";
  }
  else if (Time >= 12 == Time < 18) {
    Reply = "It is afternoon.";
  }
  else {
    Reply = "It is evening time"
  }
  document.getElementById("Time_of_day").innerHTML = Reply
} //defining a function that sets a Time variable to the current hour, and inserts one of various replys into the Time_of_Day paragraph depending on and if, else if, else logic statement.
