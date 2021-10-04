$(document).ready(function() {
    
})

function navigatePage(event) {
    if(event.id == "home") {
        debugger        
        $("#pageName").attr("src", "./home.html")
    }else if(event.id == "gallery") {
        $("#pageName").attr("src", "./gallery.html")        
    }else if(event.id == "order") {
        $("#pageName").attr("src", "./order.html")        
    }else if(event.id == "phone") {
        $("#pageName").attr("src", "./gallery.html") 
    }else if(event.id == "tablet") {
        $("#pageName").attr("src", "./gallery.html")         
    }else if(event.id == "laptop") {
        $("#pageName").attr("src", "./gallery#laptop.html ")         
    }
}