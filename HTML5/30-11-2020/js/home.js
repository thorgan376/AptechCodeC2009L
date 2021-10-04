$(document).ready(function() {
    
})
function switchPage(button) {
    if(button.id == "buttonHome") {
        $("#switchScreen").attr("src", "./home-page.html")
        $("#switchPage").html("Main menu")
        //document.getElementById("mainMenu").innerText = "juuwrrre"
    } else if(button.id == "buttonReservation") {
        $("#switchScreen").attr("src", "./reservation.html")
        $("#switchPage").html("Reservation")
    } else if(button.id == "buttonContact") {
        $("#switchScreen").attr("src", "./contact-us.html")
        $("#switchPage").html("Contact")
    }
}