
window.myBlazorInterop = {
    scan: function () {
        var myqr = document.getElementById("you-qr-result")
        var lastResult, countResults = 0;

        //If qr code founds
        
        function onScanSuccess(decodeText, decodeResult) {
            if (decodeText !== lastResult) {
                ++countResults;
                lastResult = decodeResult;
                window.globalVariable = decodeText;
                //Alert qr here
                document.getElementById("my-qr-reader").style.display = "none";
                document.getElementById("resultpage").style.display = "block";
                document.getElementById("scanresult").innerHTML = decodeText;
                //myqr.innerHTML = ` you scan ${countResults} : ${decodeText}`
                //dotNetHelper.invokeMethodAsync('Result', decodeResult)
            }
        }
        //Render camera

        var htmlscanner = new Html5QrcodeScanner(
            "my-qr-reader", { fps: 10, qrbox: 250 }
        )

        htmlscanner.render(onScanSuccess)
    },
    getTest: function () {
        return window.globalVariable;
    },
    getResult: function (instance) {
        const testa = "asd"
        instance.invokeMethodAsync('FoodDelivery', 'UpdateValue', testa)
    }
};