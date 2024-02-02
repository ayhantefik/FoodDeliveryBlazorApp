export function deviceCheck() {
    var isMobile = window.matchMedia("(max-width: 768px)").matches;
    if (isMobile) {
        document.getElementById("menutable").style.width = "100%";
    }
    else {
        document.getElementById("menutable").style.width = "60%";
    }
}