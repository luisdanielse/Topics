// JavaScript source code
var result;

async function analyzeText() {
    var text = document.getElementById('textToAnalyze').value;
    console.log(text);

    var url = "https://danielscognservice.cognitiveservices.azure.com/text/analytics/v3.2-preview.1/sentiment?opinionMining=true";
    var cogSvcKey = "46cdc71e83024398a9fc82c9dd901e77";
   
    
    // Example POST method implementation:
    postDataForText(url, { documents: [{ id: '1', text: text }] }, cogSvcKey)
        .then(data => {
            result = data;
        });
    console.log("The result is: ");
    console.log(result);
    
}


async function postDataForText(url, data, cogKey) {
    // Default options are marked with *
    const response = await fetch(url, {
        method: 'POST', // *GET, POST, PUT, DELETE, etc.
        mode: 'cors', // no-cors, *cors, same-origin
        cache: 'no-cache', // *default, no-cache, reload, force-cache, only-if-cached
        credentials: 'same-origin', // include, *same-origin, omit
        headers: {
            'Content-Type': 'application/json',
            'Ocp-Apim-Subscription-Key': cogKey
            // 'Content-Type': 'application/x-www-form-urlencoded',
        },
        redirect: 'follow', // manual, *follow, error
        referrerPolicy: 'no-referrer', // no-referrer, *no-referrer-when-downgrade, origin, origin-when-cross-origin, same-origin, strict-origin, strict-origin-when-cross-origin, unsafe-url
        body: JSON.stringify(data) // body data type must match "Content-Type" header
    });
    return response.json(); // parses JSON response into native JavaScript objects
}



async function analyzeImg() {
    var urlImage = document.getElementById('urlImgToAnalyze').value;
    console.log(urlImage);

    var url = "https://danielscognservice.cognitiveservices.azure.com/vision/v2.1/analyze?visualFeatures=Description,Tags,Categories&details=Celebrities,Landmarks";
    var cogSvcKey = "46cdc71e83024398a9fc82c9dd901e77";


    // Example POST method implementation:
    postDataForImage(url, {url: urlImage }, cogSvcKey)
        .then(data => {
            result = data;
        });
    console.log("The result is: ");
    console.log(result);

}

async function postDataForImage(url, data, cogKey){
        // Default options are marked with *
    const response = await fetch(url, {
        method: 'POST', // *GET, POST, PUT, DELETE, etc.
        mode: 'cors', // no-cors, *cors, same-origin
        cache: 'no-cache', // *default, no-cache, reload, force-cache, only-if-cached
        credentials: 'same-origin', // include, *same-origin, omit
        headers: {
            'Content-Type': 'application/json',
            'Ocp-Apim-Subscription-Key': cogKey
            // 'Content-Type': 'application/x-www-form-urlencoded',
        },
        redirect: 'follow', // manual, *follow, error
        referrerPolicy: 'no-referrer', // no-referrer, *no-referrer-when-downgrade, origin, origin-when-cross-origin, same-origin, strict-origin, strict-origin-when-cross-origin, unsafe-url
        body: JSON.stringify(data) // body data type must match "Content-Type" header
    });
    return response.json(); // parses JSON response into native JavaScript objects
}