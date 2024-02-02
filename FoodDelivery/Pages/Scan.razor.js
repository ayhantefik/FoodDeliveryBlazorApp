var test123 = "123";
export function isDomReady() {
    if (document.readyState === "complete" || document.readyState === "interactive") {
        setTimeout(isDomReady, 1)
    }
    else {
        document.addEventListener("DomContentLoaded", isDomReady)
    }
}
export function scan() {
    var myqr = document.getElementById("you-qr-result")
    var lastResult, countResults = 0;

    //If qr code founds
    function onScanSuccess(decodeText, decodeResult) {
        if (decodeText !== lastResult) {
            ++countResults;
            lastResult = decodeResult;
            test123 = decodeText;
            //Alert qr here
            alert("QR is: " + decodeText, decodeResult)
            //myqr.innerHTML = ` you scan ${countResults} : ${decodeText}`
            //dotNetHelper.invokeMethodAsync('Result', decodeResult)
        }
    }
    //Render camera

    var htmlscanner = new Html5QrcodeScanner(
        "my-qr-reader", {fps:10,qrbox:250}
    )

    htmlscanner.render(onScanSuccess)
}
export function invokeJStoBlzr(instance) {
    instance.invokeMethodAsync('Result', test123)
}

export function sayHello2(dotNetHelper) {
    return dotNetHelper.invokeMethodAsync('GetHelloMessage', test123);
}