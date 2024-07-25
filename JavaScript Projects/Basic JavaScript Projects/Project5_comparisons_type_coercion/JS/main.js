document.write(typeof true) //Using typeof operator to see the type of true. Then writing it to the page.

document.write(", six" + 6) //Concatenating the string ", six" and number 6. Then writing it to the page.

function norGate() {
  document.getElementById("Nor").innerHTML = ("!(7 == 8 || 4 > 3) = " + !(7 == 8 || 4 > 3))
} //using a nor gate to evaluate 7 == 8 and 4 > 3, then sending the result (and added text) to "Nor" paragraph.

function andGate() {
  document.getElementById("And").innerHTML= ("(20 < 34 && 10 === 10) = " + (20 < 34 && 10 === 10))
} //using an and gate to evaluate 20 < 34 and 10 === 10, then sending the result (and added text) to "And" paragraph.
