function window_onload() {
    window.addEventListener("scroll", navbar_reset_top, false);
}

var navbar_top = 100;

function navbar_reset_top() {
    var scrollTop = document.documentElement.scrollTop || document.body.scrollTop;
    if (scrollTop > navbar_top && navbar.className === "navbar_absolute") {
        document.getElementById("navbar").className = "navbar_fixed";
    }
    else if (scrollTop < navbar_top && navbar.className === "navbar_fixed") {
        document.getElementById("navbar").className = "navbar_absolute";
    }
}


// Get the image and insert it inside the modal - use its "alt" text as a caption


function enlargeImage() {
    document.getElementById("myModal").className = "modal-shown";
    var image = event.target;
    document.getElementById("modal-image").src = image.src;
    document.getElementById("caption").innerHTML = image.alt;
    
}

// Get the <span> element that closes the modal
var span = document.getElementsByClassName("close")[0];

// When the user clicks on <span> (x), close the modal
span.onclick = function () {
    document.getElementById("myModal").className = "modal-hidden";
}