const userForm = document.querySelector("#user-create-form");
const userFormSbmBtn = document.querySelector("#user-create-submit");
const laukas = document.querySelector("#pirmas");

function sendData() {
  let data = new FormData(userForm);
  let obj = {};

  data.forEach((value, key) => {
    obj[key] = value;
  });

  fetch("https://testapi.io/api/Tadasls/resource/TLSappDB/", {
    method: "post",
    headers: {
      Accept: "application/json, text/plain, */*",
      "Content-Type": "application/json",
    },
    body: JSON.stringify(obj),
  })
    .then((obj) => console.log(obj.json()))
    .catch((error) => console.log(error));
}


userFormSbmBtn.addEventListener("click", (e) => {
  e.preventDefault(); 
  sendData();
});

const userDelForm = document.querySelector('#user-delete-form');
const userDelFormSbmBtn = document.querySelector('#user-delete-submit');


function sendDataDel() {
    let data = new FormData(userDelForm);
    let obj = {};

    data.forEach((value, key) => {
        obj[key] = value
    });

    const url = 'https://testapi.io/api/Tadasls/resource/TLSappDB/' + obj.id;

    fetch(url, {
        method: 'delete',
        headers: {
            'Accept': 'application/json, text/plain, */*',
            'Content-Type': 'application/json'
        }
    })
    .then(obj => {
        const res = obj; // .json()
        console.log(res);
        return res;
    })
    .catch((error) => console.log(error));
}

userDelFormSbmBtn.addEventListener('click', (e) => {
  e.preventDefault(); 
  sendDataDel();
})


document.addEventListener('DOMContentLoaded', () => {
  const o = Object.assign({}, JSON.parse(localStorage.getItem('LocalformData')));
  pirmas.innerHTML = o.regUserName ?? ``;
  antras.innerHTML = o.regUserLastname ?? ``;
  trecias.innerHTML = o.regUserEmail ?? ``;

});

