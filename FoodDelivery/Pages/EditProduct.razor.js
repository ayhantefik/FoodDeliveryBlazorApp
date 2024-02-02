export function deviceCheck() {
    var isMobile = window.matchMedia("(max-width: 768px)").matches;
    if (isMobile) {
        document.getElementById("editproductform").style.width = "100%";
    }
    else {
        document.getElementById("editproductform").style.width = "60%";
    }
}