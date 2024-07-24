beverages = { //making a dictionary time: beverage pairs
  morning:"Drink coffee",
  afternoon:"Drink green tea",
  night:"Drink chamomile tea",
  midnight: "Drink coffee",
  postWorkout:"Drink a shake",
  thirsty:"Drink water"
}


function morning() {
  document.getElementById("Dictionary").innerHTML = beverages.morning //Replacing "Click me!" with Drink coffee.
}

function badIdea() {
  delete beverages.midnight //delete the midnight: "Drink coffee" key: value pair from beverages.
  document.getElementById("Sleep").innerHTML = beverages.midnight //try to replace the inner text of the sleep paragraph with coffee, but get undefined instead.
}
