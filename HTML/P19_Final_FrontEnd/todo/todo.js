//prisijungimo duomenys

document.addEventListener('DOMContentLoaded', () => {
  const o = Object.assign({}, JSON.parse(localStorage.getItem('UserData')));
  nulinis.innerHTML = o.ID ?? ``;
  pirmas.innerHTML = o.regUserName ?? ``;
  antras.innerHTML = o.regUserLastname ?? ``;
  trecias.innerHTML = o.regUserEmail ?? ``;
});

const arUzpyldytiVartDuomenis = () => {
  if (!type.value) return false;
  if (!content.value) return false;
  if (!endDate.value) return false;
  return true;
};


//create new

const userForm = document.querySelector("#user-edit-form");
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
   if (arUzpyldytiVartDuomenis()){
   createData();
   setTimeout(() => { viewData();}, 1000);}
   else { {window.alert('Duomenis nėra pilnai užpildyti');}}
    });

//view all for one user

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
    let htmlElement = `<p> Id: ${element.ID} Tipas: ${element.Type} Turinys: ${element.Content} Galiojimo data: ${element.EndDate}</p>`;
      htmlDuomenys += htmlElement;
    });
    duomenuVaizdavimoLaukas.innerHTML = htmlDuomenys;
  

    // let trinamasSarasas = '';
    // vienoVartotojoUzrasai.forEach(trinamas => {
    //     let sarasoElementas = `<option value="${trinamas.ID}"></option>`;
    //    trinamasSarasas += sarasoElementas;
    //  });
    //  trinami_dalykai.innerHTML = trinamasSarasas;


  });
}

userViewFormSbmBtn.addEventListener('click', (e) => {
  e.preventDefault(); 
  
  viewData();
})

//edit data

const dataForm = document.querySelector('#user-edit-form');
const dataFormSbmBtn = document.querySelector('#user-edit-form-submit');

function editData() {
    let data = new FormData(dataForm);
    let obj = {};

    data.forEach((value, key) => {
             obj[key] = value
    });
    obj['UserId'] = user.ID;

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

dataFormSbmBtn.addEventListener('click', (e) => {
    e.preventDefault(); 
    if (arUzpyldytiVartDuomenis()){
    editData();
    setTimeout(() => { viewData();}, 1000);}
    else { {window.alert('Duomenis nėra pilnai užpildyti');}}
  });


//delete  
const userDelForm = document.querySelector('#user-edit-form');
const userDelFormSbmBtn = document.querySelector('#user-delete-submit');

function sendDataDel() {
  let data = new FormData(userDelForm);
    let obj = {};
    
    data.forEach((value, key) => {
        obj[key] = value
    });

    const url = 'https://testapi.io/api/Tadasls/resource/TLSusersDuomenys/' + obj.id;
    const urlFetch = 'https://testapi.io/api/Tadasls/resource/TLSusersDuomenys/' + obj.id;
    const optionsFetch = {
        method: 'get',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        }
    }

    fetch(urlFetch, optionsFetch)
    .then((response) => response.json())
    .then((a) => {
        console.log(`exists: ${a}`);
        return fetch(url, {
            method: 'delete',
            headers: {
                'Accept': 'application/json, text/plain, */*',
                'Content-Type': 'application/json'
            }
        })
    })
    .then(obj => { 
        const res = obj; //.json()
        console.log(res);
        return res;
    })
    .catch((error) => {
        console.log(`Request failed with error: ${error}`);
    })}

userDelFormSbmBtn.addEventListener('click', (e) => {
  e.preventDefault(); 
  if (confirm(`Ištrinti?`) == true) {
    sendDataDel();
   setTimeout(() => { viewData();}, 1000);
  }})




