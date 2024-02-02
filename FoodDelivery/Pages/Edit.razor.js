export function deviceCheck() {
    var isMobile = window.matchMedia("(max-width: 768px)").matches;
    if (isMobile) {
        document.getElementById("editform").style.width = "100%";
    }
    else {
        document.getElementById("editform").style.width = "60%";
    }
}