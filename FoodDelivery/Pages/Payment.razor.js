export function deviceCheck() {
    var isMobile = window.matchMedia("(max-width: 768px)").matches;
    var itemrow = document.getElementById("itemRow");
    var paymentrow = document.getElementById("paymentRow");
    if (isMobile) {
        if (itemrow !== null) {
            itemrow.style.width = "100%";
        }
        if (paymentrow !== null) {
            paymentrow.style.width = "80%";
        }
    }
    else {
        if (itemrow !== null) {
            itemrow.style.width = "50%";
        }
        if (paymentrow !== null) {
            paymentrow.style.width = "30%";
        }
    }
}