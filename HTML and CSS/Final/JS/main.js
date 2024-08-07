function openForm() {
  document.getElementById("contactForm").style.display = "block";
}

function closeForm() {
  document.getElementById("contactForm").style.display = "none";
}

document.addEventListener("click", function(event) {
  if (event.target.matches(".close") || !event.target.closest(".form-popup") && !event.target.closest(".contact-button") && !event.target.closest(".contact")){
    closeForm()
  }
}, false)

var slideIndex = 1;
showSlides(slideIndex)

function plusSlides(n) {
  showSlides(slideIndex += n);
}

function currentSlide(n) {
  showSlides(slideIndex = n);
}

function showSlides (n) {
  var slides = document.getElementsByClassName("slides");
  if (n > slides.length) {slideIndex = 1};
  if (n < 1) {slideIndex = slides.length};
  for (i = 0; i < slides.length; i++) {
    slides[i].style.display = "none";
  }
  slides[slideIndex -1].style.display = "block"
}
