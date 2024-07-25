var worldlyVariable = "present"

function smallTown() {
  var smallTownVariable = "local"
}

function meeting() {
  console.log(smallTownVariable)
  /* document.getElementById("meeting").innerHTML = "worldlyVariable is " + worldlyVariable + ", smallTownVariable's location is " + smallTownVariable; */

}

function coffeeTime() {
  if (new Date().getHours() < 14) {
    document.getElementById("Coffee").innerHTML = "No, let's grab an espresso!"
  }
  else {
    document.getElementById("Coffee").innerHTML = "Yeah, I'd be up all night if I had one now."
  }
}

function haunted() {
  var concern = document.getElementById("No")
  var haunt =document.getElementById("Haunted")
  if (concern.checked) {
    haunt.innerHTML = "Get out! This place is haunted!!!"
  }
  else {
    haunt.innerHTML = "Relax, it's just the wind."
  }
}

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
}
