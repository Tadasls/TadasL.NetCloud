const animalForm = document.querySelector('#animal-form');
const animalFormSbmBtn = document.querySelector('#animal-form-submit');

function sendData() {
    let data = new FormData(animalForm);
    let obj = {};


    data.forEach((value, key) => {
        obj[key] = value
    });

    const url = 'https://testapi.io/api/Tadasls/resource/Animals/' + obj.id;

    fetch(url, {
        method: 'delete',
        headers: {
            'Accept': 'application/json, text/plain, */*',
            'Content-Type': 'application/json'
        }
    })
    .then(obj => {
        const res = obj.json()
        console.log(res);
        return res;
    })
    .catch((klaida) => console.log(klaida));
}

animalFormSbmBtn.addEventListener('click', (e) => {
    e.preventDefault(); 
    sendData();
})