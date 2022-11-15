const Form = document.querySelector('#form');
const FormSbmBtn = document.querySelector('#form-submit');

function sendData() {
    let data = new FormData(Form);
    let obj = {};

    data.forEach((value, key) => {
        obj[key] = value
    });
                
    const url = 'https://testapi.io/api/Tadasls/resource/TLSusersDuomenys/' + obj.id;
   
    fetch(url, {
        method: 'put',
        headers: {
            'Accept': 'application/json, text/plain, */*',
            'Content-Type': 'application/json'
        },
     
        body: JSON.stringify(obj) 
    })
    .then(obj => {
        const res = obj.json()
        console.log(res);
        return res;
    })
    .catch((klaida) => console.log(klaida));
}

FormSbmBtn.addEventListener('click', (e) => {
    e.preventDefault();
    sendData();
})