export function browserColor(list, browse) {
    list.forEach((element) => {
        document.getElementById(element).style.backgroundColor = "black";
        document.getElementById(element).style.color = "white";
    }
    );
    document.getElementById(browse).style.backgroundColor = "white";
    document.getElementById(browse).style.color = "black";
}
export function deviceCheck() {
    var isMobile = window.matchMedia("(max-width: 768px)").matches;
    if (isMobile) {
        document.getElementById("menudivid").style.width = "100%";
        document.getElementById("choosenitemid").style.width = "100%";
    }
    else {
        document.getElementById("menudivid").style.width = "60%";
        document.getElementById("choosenitemid").style.width = "50%";
    }
}