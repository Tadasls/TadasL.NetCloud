//prisijungimo duomenys

document.addEventListener('DOMContentLoaded', () => {
  const o = Object.assign({}, JSON.parse(localStorage.getItem('UserData')));
  nulinis.innerHTML = o.ID ?? ``;
  pirmas.innerHTML = o.regUserName ?? ``;
  antras.innerHTML = o.regUserLastname ?? ``;
  trecias.innerHTML = o.regUserEmail ?? ``;
});

//create new

const userForm = document.querySelector("#user-create-form");
const userFormSbmBtn = document.querySelector("#user-create-submit");
const user = JSON.parse(localStorage.getItem('UserData'));

function createData() {
  let data = new FormData(userForm);
  let obj = {};
 
  data.forEach((value, key) => {
    obj[key] = value;
  });
  obj['UserId'] = user.ID;

  fetch("https://testapi.io/api/Tadasls/resource/TLSusersDuomenys", {
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
   createData();
    });


//view all for user

const userViewForm = document.querySelector('#user-create-form');
const userViewFormSbmBtn = document.querySelector('#user-view-submit');

const url = 'https://testapi.io/api/Tadasls/resource/TLSusersDuomenys';
const options = {
  method: 'get',
  headers: {      
      'Accept': 'application/json',   
           'Content-Type': 'application/json'  
  }
}
const response = {};

function viewData(){
  fetch(url, options)
  .then( (response) => response.json())
  .then((duomenys) => {
      // console.log(duomenys);
    const vienoVartotojoUzrasai = [];

    for (const uzrasas of duomenys.data) {
        if (uzrasas.UserId === user.ID) {
          vienoVartotojoUzrasai.push({
            ID: uzrasas.id,
            Type: uzrasas.type,
            Content: uzrasas.content,
            EndDate: uzrasas.endDate,
            Created: uzrasas.createdAt.slice(0, 10) + ' ' + uzrasas.createdAt.slice(11, 19),
            Updated: uzrasas.updatedAt.slice(0, 10) + ' ' + uzrasas.updatedAt.slice(11, 19)
          });
          
        }
    }
     console.log(vienoVartotojoUzrasai);
   const duomenuVaizdavimoLaukas = document.getElementById('data-text');
   let htmlDuomenys = '';

   vienoVartotojoUzrasai.forEach(element => {
     console.log(element);
    let htmlElement = `<p> Tipas: ${element.Type} Turinys: ${element.Content} Galiojimo data: ${element.EndDate}</p>`;
      htmlDuomenys += htmlElement;
    });

    duomenuVaizdavimoLaukas.innerHTML = htmlDuomenys;
  
  });
}

userViewFormSbmBtn.addEventListener('click', (e) => {
  e.preventDefault(); 
  viewData();
})








const userDelForm = document.querySelector('#user-delete-form');
const userDelFormSbmBtn = document.querySelector('#user-delete-submit');

function sendDataDel() {
    let data = new FormData(userDelForm);
    let obj = {};

    data.forEach((value, key) => {
        obj[key] = value
    });

    const url = 'https://testapi.io/api/Tadasls/resource/TLSusersDuomenys/' + obj.id;

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




