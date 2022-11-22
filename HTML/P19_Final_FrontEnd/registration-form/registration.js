const newRegForm = document.querySelector("#new-registration-form");
const newRegFormSbmBtn = document.querySelector("#new-registration-form-submit");
const logFirstName = document.querySelector('#regUserName');
const logLastName = document.querySelector('#regUserLastname');
const logEmail = document.querySelector('#regUserEmail');

const arUzpyldytiDuomenis = () => {
  if (!logFirstName.value) return false;
  if (!logLastName.value) return false;
  if (/^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/.test(logEmail.value)){ return (true)}
else return false;
  return true;
};






function sendRegData() {
  let data = new FormData(newRegForm);
  let obj = {};

  data.forEach((value, key) => {
    obj[key] = value;
  });
  
  // fetch("https://testapi.io/api/Tadasls/resource/TLSusersDB",
  fetch("https://localhost:7125/api/user/create",
   {
    method: "post",
    headers: {
      Accept: "application/json",
      "Content-Type": "application/json",
    },
    body: JSON.stringify(obj),
  })
    .then((obj) => console.log(obj.json()))

    .catch((error) => console.log(error));
   
    window.alert(`vartotojas uzregistruotas ${Object.values(obj)}`);
}

newRegFormSbmBtn.addEventListener("click", (e) => {
  e.preventDefault();
  arEgzistuojaToksVartotojas();
    });

  function duomenuSiuntimasToDB() {
    if(arUzpyldytiDuomenis()){ 
          sendRegData();
          saveLocalFormData('regUserName', logFirstName.value);
          saveLocalFormData('regUserLastname', logLastName.value);
          saveLocalFormData('regUserEmail', logEmail.value);
        sessionStorage.clear();
        window.location = '../login-form/login.html';
     } else { 
      window.alert('Duomenis nėra teisingai užpildyti');
    } 
    
  }






//saugoti registraciju duomenis

const saveLocalFormData = (key, value) => {
  const localJson = localStorage.getItem('UserData'); 
  const obj = JSON.parse(localJson); 
  const o = Object.assign({}, obj); 
  o[key] = value; 
  localStorage.setItem('UserData', JSON.stringify(o)); 
};

//saugoti formu duomenis

const saveFormData = (key, value) => {
  const json = sessionStorage.getItem('formData'); 
  const obj = JSON.parse(json); 
  const o = Object.assign({}, obj); 
  o[key] = value; 
  sessionStorage.setItem('formData', JSON.stringify(o)); 
};

regUserName.addEventListener('change', (e) => {
  saveFormData('regUserName', e.target.value);
});
regUserLastname.addEventListener('change', (e) => {
  saveFormData('regUserLastname', e.target.value);
});
regUserEmail.addEventListener('change', (e) => {
  saveFormData('regUserEmail', e.target.value);
});

document.addEventListener('DOMContentLoaded', () => {
  const o = Object.assign({}, JSON.parse(sessionStorage.getItem('formData')));
  regUserName.value = o.regUserName ?? ``;
  regUserLastname.value = o.regUserLastname ?? ``;
  regUserEmail.value = o.regUserEmail ?? ``;
});



//validacija


function arEgzistuojaToksVartotojas() {
  let userExists = false
 
  // const url = 'https://testapi.io/api/Tadasls/resource/TLSusersDB';
  const url = 'https://localhost:7125/api/user/get';
  const options = {
      method: 'get',
      headers: {
          'Accept': 'application/json',
          'Content-Type': 'application/json'
      }}
      fetch(url, options)
      .then((response) => response.json())
      .then((duomenys) => {
        for (const klientas of duomenys) {      
              if(klientas.userName.toLowerCase() === regUserName.value.toLowerCase() && 
                klientas.userLastname.toLowerCase() === regUserLastname.value && 
                klientas.userEmail === regUserEmail.value) 
              {userExists = true};
            }
              if(userExists){
                window.alert('Toks vartotojas Jau YRA Uzregistruotas');
                return false;
              }            
              else 
              {
                duomenuSiuntimasToDB();
                  return true;
              }
      })
      .catch(
                (klaida) => console.log(klaida)
        );
    }




  