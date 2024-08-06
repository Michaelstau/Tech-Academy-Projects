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
