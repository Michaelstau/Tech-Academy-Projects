
/**
 * loops through all size class elements and sets selectedSize to the value of the checked element.
 * assigns size total a number based on the selected size
 * console logs pizza size, price (before topping), text1, and subtotal
 * sends runningTotal and text1 to getTopping()
 */
function getReceipt() {
  var text1 = "<h3>You Ordered:</h3>";
  var runningTotal = 0;
  var sizeTotal = 0;
  var sizeArray = document.getElementsByClassName("size");
  for (var i = 0; i < sizeArray.length; i++) {
    if (sizeArray[i].checked) {
      var selectedSize = sizeArray[i].value;
      text1 += selectedSize+"<br>";
    }
  }
  if (selectedSize === "Personal Pizza") {
    sizeTotal = 6;
  } else if (selectedSize === "Medium Pizza") {
    sizeTotal = 10;
  } else if (selectedSize === "Large Pizza") {
    sizeTotal = 14;
  } else if (selectedSize === "Extra Large Pizza") {
    sizeTotal = 16;
  } else if (selectedSize === "Extra Extra Large Pizza") {
    sizeTotal = 18;
  }
  runningTotal = sizeTotal;
  console.log(selectedSize+" = $"+sizeTotal+".00");
  console.log("size text1: "+text1);
  console.log("subtotal: $"+runningTotal+".00");
  getTopping(runningTotal, text1)
}

/**
 * loops through all topping class elements and adds values of checked elements to selectedTopping, console logs it with a string for context and adds it to text1 with a <br>.
 * assigns toppingCount to the length of the selectedTopping array, and toppingTotal to one less than that (or 0)
 * console logs and displays the rest of our recipt.
 */

function getTopping(runningTotal,text1) {
  var toppingTotal = 0;
  var selectedTopping = [];
  var toppingArray = document.getElementsByClassName("toppings");
  for (var j = 0; j < toppingArray.length; j++) {
    if (toppingArray[j].checked) {
      selectedTopping.push(toppingArray[j].value);
      console.log("selected topping item: ("+toppingArray[j].value+")");
      text1 += toppingArray[j].value+"<br>"
    }
  }
  var toppingCount = selectedTopping.length;
  if (toppingCount > 1) {
    toppingTotal = (toppingCount - 1)
  } else {
    toppingTotal = 0;
  }
  runningTotal = (runningTotal + toppingTotal);
  console.log("total selected topping items: "+toppingCount);
  console.log(toppingCount+" topping - 1 free topping = $"+toppingTotal+".00");
  console.log("topping text1: "+text1);
  console.log("Purchase Total: $"+runningTotal+".00");
  document.getElementById("showText").innerHTML=text1;
  document.getElementById("totalPrice").innerHTML="<h3>Total: <strong>$"+runningTotal+".00</strong></h3>"
};
