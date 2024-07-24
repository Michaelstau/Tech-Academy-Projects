var x = 2
function add() {
  x = x + 6;
  document.getElementById("math").innerHTML = "x + 6 = " + x
}

function subtract() {
  x = x - 6;
  document.getElementById("math").innerHTML = "x - 6 = " + x
}

function multiply() {
  x = x * 6;
  document.getElementById("math").innerHTML = "x * 6 = " + x
}

function divide() {
  x = x / 6;
  document.getElementById("math").innerHTML = "x / 6 = " + x
}

function modulus() {
  x = x % 6
  document.getElementById("math").innerHTML = "x % 6 = " + x
}

function negation() {
  x = -x
  document.getElementById("math").innerHTML = "-x = " + x
}

function increment() {
  x++
  document.getElementById("math").innerHTML = "x++ = " + x
}

function decrement() {
  x--
  document.getElementById("math").innerHTML = "x-- = " + x
}

function random() {
  x = Math.random()
  document.getElementById("math").innerHTML = "x randomized = " + x
}

function smallest() {
  document.getElementById("math").innerHTML = "between " + x + " and 6, " + Math.min(6, x) + " is smaller"
}
