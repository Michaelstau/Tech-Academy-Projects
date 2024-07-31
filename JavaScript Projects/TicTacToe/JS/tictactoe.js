let player = "X";
let selectedSquares = [];

function placeXOrO(squareNumber) {
  if (!selectedSquares.some(element => element.includes(squareNumber))) {
    let select = document.getElementById(squareNumber);
    if (player === "X") {
      select.style.backgroundImage = 'url("images/yinYang.jpg")';
    } else {
      select.style.backgroundImage = 'url("images/pentagram.jpg")';
    }
    selectedSquares.push(squareNumber + player);

    checkWinConditions();

    if (player === "X") {
      player = "O"
    } else {
      player = "X"
    }
    audio("./media/altPlace.wav");
    if (player === "O") {
      disableClick();
      setTimeout(function () { computerTurn(); }, 1000);
    }
    return true;
  } //if the square clicked is already in selectedSquares does nothing. If not, changes to background of the clicked square to the current players background, adds the square (formatted as player + squareNumber) to selectedSquares array, calls checkWinConditions, switches the player from X to O (or O to X) and plays altPlace audio (while disabling click for one second.)

  function checkWinConditions() {
    if (arrayIncludes(`0${player}`,`1${player}`,`2${player}`)) { drawWinLine(50, 100, 558, 100)}
    else if (arrayIncludes(`3${player}`,`4${player}`,`5${player}`)) { drawWinLine(50, 304, 558, 304)}
    else if (arrayIncludes(`6${player}`,`7${player}`,`8${player}`)) { drawWinLine(50, 508, 558, 508)}
    else if (arrayIncludes(`0${player}`,`3${player}`,`6${player}`)) { drawWinLine(100, 50, 100, 558)}
    else if (arrayIncludes(`1${player}`,`4${player}`,`7${player}`)) { drawWinLine(304, 50, 304, 558)}
    else if (arrayIncludes(`2${player}`,`5${player}`,`8${player}`)) { drawWinLine(508, 50, 508, 558)}
    else if (arrayIncludes(`6${player}`,`4${player}`,`2${player}`)) { drawWinLine(100, 508, 510, 90)}
    else if (arrayIncludes(`0${player}`,`4${player}`,`8${player}`)) { drawWinLine(100, 100, 520, 520)}
    else if (selectedSquares.length >= 9) {
      audio("./media/altTie.mp3")
      setTimeout(function () { resetGame(); }, 500);
    }
    function arrayIncludes(squareA, squareB, squareC) {
      const a = selectedSquares.includes(squareA);
      const b = selectedSquares.includes(squareB);
      const c = selectedSquares.includes(squareC);
      if (a === true && b=== true && c === true) { return true; }
    }
  } //Checking to see if any of the win condition patterns are met with if and else if statements and arrayIncludes. Then checking to see if all squares are filled, in shich case, play altTie.mp3 and call resetGame with a half second delay.

  function computerTurn() {
    let success = false;
    let pickASquare;
    while (!success) {
      pickASquare = String(Math.floor(Math.random() * 9));
      if (placeXOrO(pickASquare)) {
        placeXOrO(pickASquare);
        success = true;
      }
    }
  }
} //in a while loop, picks a rondom number from 0 to 8. if calling placeXOrO with that number returns true, placeXOrO is called with the number and the loop ends, otherwise it continues.

function disableClick() {
  body.style.pointerEvents = "none";
  setTimeout(function () { body.style.pointerEvents = "auto"; }, 1000)
}//Disables pointerEvents on the body element for a second.

function audio(audioURL) {
  let audio = new Audio(audioURL);
  audio.play();
} //plays an audio file.

function drawWinLine(coordX1, coordY1, coordX2, coordY2) {
  const canvas = document.getElementById("win-lines");
  const c = canvas.getContext("2d");
  let x1 = coordX1, y1 = coordY1, x2 = coordX2, y2 = coordY2, x = x1, y = y1;
  function animateLineDrawing() {
    const animationLoop = requestAnimationFrame(animateLineDrawing);
    c.clearRect(0,0,608,608);
    c.beginPath();
    c.moveTo(x1, y1);
    c.lineTo(x,y)
    c.lineWidth = 10;
    c.strokeStyle = "rgba(70, 255, 33, .8)"
    c.stroke();
    if (x1 <= x2 && y1 <= y2) {
      if (x <= x2) { x += 10; }
      if (y <= y2) { y += 10; }
      if (x >= x2 && y >= y2) {cancelAnimationFrame(animationLoop); }
    }
  }
  function clear() {
    const animationLoop = requestAnimationFrame(clear);
    c.clearRect(0,0,608,608);
    cancelAnimationFrame(animationLoop);
  }
  disableClick();
  audio("./media/altWinGame.mp3")
  animateLineDrawing();
  setTimeout(function() { clear(); resetGame(); }, 1000)
}//Draws the winning line on our board from coordX1 to coordY1. Then clears the canvas, calls resetGame, and prevents clicking for 1 second

function resetGame() {
  for (let i=0; i<9; i++) {
    let square = document.getElementById(String(i));
    square.style.backgroundImage = "";
  }
  selectedSquares = [];
} //Loops through the 9 squares removing background images, then sets selectedSquares to be an empty array.
