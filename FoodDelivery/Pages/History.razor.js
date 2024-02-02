export function deviceCheck() {
    var isMobile = window.matchMedia("(max-width: 768px)").matches;
    if (isMobile) {
        document.getElementById("historyid").style.width = "100%";
    }
    else {
        document.getElementById("historyid").style.width = "50%";
    }
}