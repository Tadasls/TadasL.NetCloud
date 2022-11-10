const newRegForm = document.querySelector("#new-registration-form");
const newRegFormSbmBtn = document.querySelector("#new-registration-form-submit");
const logFirstName = document.querySelector('#regUserName');
const logLastName = document.querySelector('#regUserLastname');
const logEmail = document.querySelector('#regUserEmail');

function sendRegData() {
  let data = new FormData(newRegForm);
  let obj = {};

  data.forEach((value, key) => {
    obj[key] = value;
  });
	       
  fetch("https://testapi.io/api/Tadasls/resource/TLSusersDB", {
    method: "post",
    headers: {
      Accept: "application/json, text/plain, */*",
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
  sendRegData();
  saveLocalFormData('regUserName', logFirstName.value);
  saveLocalFormData('regUserLastname', logLastName.value);
  saveLocalFormData('regUserEmail', logEmail.value);
 
  sessionStorage.clear();
  window.location = '../todo/todo.html';
});


const saveLocalFormData = (key, value) => {
  const localJson = localStorage.getItem('LocalformData'); 
  const obj = JSON.parse(localJson); 
  const o = Object.assign({}, obj); 
  o[key] = value; 
  localStorage.setItem('LocalformData', JSON.stringify(o)); 
};

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
  userName.value = o.userName ?? ``;
  userLastname.value = o.userLastname ?? ``;
  userEmail.value = o.userEmail ?? ``;
});

