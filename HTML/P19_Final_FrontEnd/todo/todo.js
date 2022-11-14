//prisijungimo duomenys

document.addEventListener('DOMContentLoaded', () => {
  const o = Object.assign({}, JSON.parse(localStorage.getItem('UserData')));
  nulinis.innerHTML = o.ID ?? ``;
  pirmas.innerHTML = o.regUserName ?? ``;
  antras.innerHTML = o.regUserLastname ?? ``;
  trecias.innerHTML = o.regUserEmail ?? ``;
  setTimeout(() => { viewData();}, 1000);
});

//validacijos
const arUzpyldytiVartDuomenis = () => {
  if (!type.value) return false;
  if (!content.value) return false;
  if (!endDate.value) return false;
  return true;
};

const arUzpildytiIdData = () => {
  if (!id.value) return false;
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
 
   const duomenuVaizdavimoLaukas = document.getElementById('data-text');
   let htmlDuomenys = '';

   vienoVartotojoUzrasai.forEach(element => {
      let htmlElement = `<p> Id: ${element.ID} Tipas: ${element.Type} Turinys: ${element.Content} Galiojimo data: ${element.EndDate}</p>` + `<hr>`;
      htmlDuomenys += htmlElement;
    });
    duomenuVaizdavimoLaukas.innerHTML = htmlDuomenys;
  
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
    if (arUzpyldytiVartDuomenis() && arUzpildytiIdData()){
      validateDataEditinimui();
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
    };
   const optionsDel = {
    method: 'delete',
    headers: {
        'Accept': 'application/json, text/plain, */*',
        'Content-Type': 'application/json'
    }
};
    
    fetch(urlFetch, optionsFetch)
    .then((response) => response.json())
    .then((a) => {
        return fetch(url, optionsDel)
    })
    .then(obj => { 
        const res = obj; //.json()
        console.log(res);
        return res;
    })
    .catch((error) => {
        console.log(`Request failed with error: ${error}`);
    });

  };


userDelFormSbmBtn.addEventListener('click', (e) => {
  e.preventDefault(); 
  if (arUzpildytiIdData()){
  if (confirm(`Ištrinti? ${id.value} Įrašą`) == true) {  
    validateDataTrynimiui();
  }} else {window.alert('Nėra pasirinktas trinamo elemento Id');}
});


add_actions.addEventListener('click', showForm);
 function showForm() {
document.getElementById("editforma").style.display = (editforma.style.display == "none") ? "block" : "none"; 
}
 





// add_actions.addEventListener('click', (e) => {
// document.querySelector('#SpecVieta').innerHTML = VeiksmuMeniu[0].AVeiksmas;

// })

// const VeiksmuMeniu = [
//   {
//     AVeiksmas: `<div class="edit">
//     CREATE & EDIT & DELETE
//     <br /><br />
//     <form id="user-edit-form">
//       <label for="name">Id</label>
//       <input type="number" name="id" id="id" /> <br /><br />
//       <label for="type">Type</label>
//       <input type="text" name="type" id="type" placeholder="Pranšimo Tipas" />  
//       <br /><br />
//       <label for="content">Content</label>
//       <input type="text" name="content" id="content" placeholder="Jūsų pranešimo turinys" />
//       <br /><br />
//       <label for="endDate">EndDate</label>
//       <input type="text" name="endDate" id="endDate" placeholder="Galiojimo data" />
//       <br /><br />
//       <input type="button" id="user-create-submit" value="Įrašyti" />
//       <input type="button" id="user-edit-form-submit" value="Atnaujinti" />
//       <input type="button" id="user-delete-submit" value="Trinti">
//     </form>
//   </div>`,
//   }
//   ,
//   {}
// ];



//validacijos papildomai

const userON = JSON.parse(localStorage.getItem('UserData'));
const url2 = 'https://testapi.io/api/Tadasls/resource/TLSusersDuomenys';
const options2 = {
  method: 'get',
  headers: {      
      'Accept': 'application/json',   
           'Content-Type': 'application/json'  
  }}
const response2 = {};

let irasasRastas = false;
function validateDataTrynimiui(){
  fetch(url2, options2)
  .then((response) => response.json())
  .then((informacija) => {
    for (const pranesimas of informacija.data) {
        if (pranesimas.UserId === userON.ID) 
        {
          if (pranesimas.id == id.value)
          {
            irasasRastas = true;
          } 
        }
      }
      if (irasasRastas) {
        sendDataDel();
      window.alert('Įrašas ištrintas');
      setTimeout(() => { viewData();}, 1000);
      }   
      else {
        window.alert('Tokio įrašo nėra')
      }
    })
    };

    
let irasasRastas2Edit = false;
function validateDataEditinimui(){
  fetch(url2, options2)
  .then((response) => response.json())
  .then((informacija) => {
    for (const pranesimas of informacija.data) {

        if (pranesimas.UserId === userON.ID) 
        {
          if (pranesimas.id == id.value)
          {
            irasasRastas2Edit = true;
          } 
        }
      }
      if (irasasRastas2Edit) {
      editData();

      window.alert('Įrašas pakoreguotas');
      setTimeout(() => { viewData();}, 1000);
      }   
      else {
        window.alert('Tokio įrašo nėra')
      }
    })
    };