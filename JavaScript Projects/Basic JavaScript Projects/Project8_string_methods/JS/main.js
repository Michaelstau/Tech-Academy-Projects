function concatMethod() {
  drink = "drink "
  document.getElementById("Concat").innerHTML = drink.concat("more ", "coffee ")
} //a function that sets a variable, and then ises concat() to add to it, and then places it into the "Concat" paragraph.

function sliceMethod() {
  var sentence = document.getElementById("Slice").innerHTML
  sentence = sentence.slice(0, sentence.length - 1)
  document.getElementById("Slice").innerHTML = sentence
} //a function that sets a variable to the inside of the "Slice" paragraph element, then reassigns it everything but the last letter, and replaces the content of the "Slice" paragraph with it.

function toStringMethod () {
  var number = 8290557.69850
  document.getElementById("String").innerHTML = number.toPrecision(7).toString()
} //a function that assigns a number variable, rounds it to 7 digits, converts it to a string, and places it inside the "String" paragraph element.


/*
more string methods:
toUpperCase() changes string to uppercase
search() searches a string for the first instance of parameter, and returns it's position
valueOf() returns the primitive value of a string
 */

/*
numbers methods:
toString() changes a num to string type.
toPrecision() makes a a number a certain length of digits.
toFixed() rounds the number to a specific decimal, and converts it to a string.
 */
