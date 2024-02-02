export function fullScreenMenu(elementName) {
    var isMobile = window.matchMedia("(max-width: 768px)").matches;
    var element = document.getElementsByClassName(elementName)
    var mobile = document.getElementById("mobilenav");
    if (isMobile) {
        if (element) {
            mobile.style.display = "block";
        }
    }
}
export function closeMenu() {
    var mobile = document.getElementById("mobilenav");
    mobile.style.display = "none";
}