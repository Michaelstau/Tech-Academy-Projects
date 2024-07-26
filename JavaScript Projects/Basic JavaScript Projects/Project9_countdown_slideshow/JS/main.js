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

let slideIndex = 1;
showSlides(slideIndex)

function plusSlides(n) {
  showSlides(slideIndex += n);
}

function currentSlide(n) {
  showSlides(slideIndex = n)
}

function showSlides(n) {
  let i;
  let slides = document.getElementsByClassName("slide-fade");
  let dots = document.getElementsByClassName("dot");
  if (n > slides.length) {slideIndex = 1}
  if (n < 1) {slideIndex = slides.length}
  for (i = 0; i < slides.length; i++) {
    slides[i].style.display = "none";
  }
  for (i = 0; i < dots.length; i++) {
    dots[i].className = dots[i].className.replace(" active", "")
  }
  slides[slideIndex-1].style.display = "block";
  dots[slideIndex-1].className += " active"
}
