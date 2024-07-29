function whileLoop() {
  let paragraph = document.getElementById("Loop")
  let phrase = "Let's get loopy!"
  let i = 0
  while (i < phrase.length) {
    paragraph.innerHTML = phrase.slice(0,i);
    i++
  }
} // uses a while loop to display the phrase "Let's get loopy!" adding one letter per iteration to "Loop" element (though, to the user it just displays all at once.)

function forLoop() {
  let coffee = ["$3.99 Latte", "$3.99 Cappaccino", "$2.99 Americano", "$4.50 Mocha", "$3.99 Macchiato", "$2.50 Ristretto", "$1.99 Drip"]
  menu = document.getElementById("Menu")
  menu.innerHTML = ""
  for (i = 0; i < coffee.length; i++){
    menu.innerHTML += coffee[i] + "<br>"
    console.log(i)
  }
} // defines an array of coffee/price strings and then uses a for loop to display each item of the array to the "menu" element.

let desk = {
  wood:"oak",
  hightInches: 34,
  raise: function() {
    desk.hightInches+=1
    document.getElementById("desk-height").innerHTML=desk.hightInches
  },
  lower: function() {
    desk.hightInches-=1
    document.getElementById("desk-height").innerHTML=desk.hightInches
  },
} // defines a "desk" object with two properties and two methods that change the heightInches property, and replace "desk-height" element's inner text with the current height.
