function countdown() {
  var seconds = document.getElementById("Seconds").value;

  function tick() {
    seconds = seconds - 1;
    Timer.innerHTML = seconds;
    var time = setTimeout(tick, 1000);
    if (seconds == -1) {
      alert("Time's up!");
      clearTimeout(time)
      timer.inerHTML = ""
    }
  }
  tick();
}

let slideIndex = 1; //assigns the slideIndex a value of one when first loading page.
showSlides(slideIndex) //calls showSlides as soon as page loads.

function plusSlides(n) {
  showSlides(slideIndex += n);
} // causes the slide Index to increment by n, and to call showSlides with the new value

function currentSlide(n) {
  showSlides(slideIndex = n)
} //sets slideIndex to a specific number n and calls showSlides with that value.

function showSlides(n) {
  let i;
  let slides = document.getElementsByClassName("slide-fade");
  let dots = document.getElementsByClassName("dot");
    //creates 3 variables, slides and dots are assigned elements from our html, while i is left unassigned.
  if (n > slides.length) {slideIndex = 1}
    //if the slide index is greater than the number of slides available, set it back to 1.
  if (n < 1) {slideIndex = slides.length}
    //if slideIndex falls below 1, set if to equal the number of slides we have (ie pointing at the last slide)
  for (i = 0; i < slides.length; i++) {
    slides[i].style.display = "none";
  } //loop through the slides variable and set the css display of all the slides to "none"
  for (i = 0; i < dots.length; i++) {
    dots[i].className = dots[i].className.replace(" active", "")
  } //loop through the dots variable and replace any class names of " active" with ""
  slides[slideIndex-1].style.display = "block";
  //change the css display of the slide at slideIndex - 1 in the slides variable to "block", so we can see it.
  dots[slideIndex-1].className += " active"
  //change the css class name of the dot at slideIndex -1 in the dots variable to " active", so it's background color changes.
}
