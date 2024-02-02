export function deviceCheck() {
    var isMobile = window.matchMedia("(max-width: 768px)").matches;
    if (isMobile) {
        document.getElementById("eateryBtn").style.width = "100%";
    }
    else {
        document.getElementById("eateryBtn").style.width = "40%";
    }
}