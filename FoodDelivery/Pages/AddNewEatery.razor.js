export function deviceCheck() {
    var isMobile = window.matchMedia("(max-width: 768px)").matches;
    if (isMobile) {
        document.getElementById("neweateryform").style.width = "100%";
    }
    else {
        document.getElementById("neweateryform").style.width = "60%";
    }
}