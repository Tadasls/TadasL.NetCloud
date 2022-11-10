const logFirstName = document.querySelector('#logfirstName');
const logLastName = document.querySelector('#loglastname');
const loginFormSbmBtn = document.querySelector('#login_form_submit');
const url = 'https://testapi.io/api/Tadasls/resource/TLSusersDB';

const options = {
  method: 'get',
  headers: {      
    'Accept': 'application/json, text/plain, */*',
    'Content-Type': 'application/json'
  }
}

function patikrintiVartotojus(){
fetch('https://testapi.io/api/Tadasls/resource/TLSusersDB')
  .then((response) => response.json())
  .then((userData) => 
  {
    userData.data.forEach(user => {
      if(user.userName === logFirstName.value && user.userLastname === logLastName.value)
      {console.log(`vardas ${user.userName} ir pavarde ${user.userLastname} ir email ${user.userEmail}`);
      // usersData.innerHTML = 'Vartotojas rastas ' + user.userEmail;
      window.alert(`Sveiki prisijunge ${user.userName} `);
      saveLocalFormData('regUserName', user.userName);
      saveLocalFormData('regUserLastname', user.userLastname);
      saveLocalFormData('regUserEmail', user.userEmail);
      sessionStorage.clear();
      window.location = '../todo/todo.html';
     } 
     
    });
    window.alert(`Toks vartotojas Neegzistuoja `);

  })
  .catch((klaida) => console.log(klaida));
}




loginFormSbmBtn.addEventListener("click", (e) => {
    e.preventDefault();
     patikrintiVartotojus(); 
  });
  
  const saveLocalFormData = (key, value) => {
    const localJson = localStorage.getItem('LocalformData'); 
    const obj = JSON.parse(localJson); 
    const o = Object.assign({}, obj); 
    o[key] = value; 
    localStorage.setItem('LocalformData', JSON.stringify(o)); 
  };
  



  const saveLogFormData = (key, value) => {
    const json = sessionStorage.getItem('SessionformData'); //nuskaitome rakta is sessionSorage
    const obj = JSON.parse(json); //nuskaityta string verciame i objekta
    const o = Object.assign({}, obj); //padarome objekta jeigu obj yra undefined
    o[key] = value; //pakeiciam o properti, jeigu tokio propercio objekte nera - sukuriamas naujas
    sessionStorage.setItem('SessionformData', JSON.stringify(o)); //graziname pakeistas reiksmes i sessionSorage
  };

  logFirstName.addEventListener('change', (e) => {
    saveLogFormData('firstName', e.target.value);
  });
  logLastName.addEventListener('change', (e) => {
    saveLogFormData('lastname', e.target.value);
  });
  
  
  document.addEventListener('DOMContentLoaded', () => {
    const o = Object.assign({}, JSON.parse(sessionStorage.getItem('SessionformData')));
    logFirstName.value = o.firstName ?? ``;
    logLastName.value = o.lastname ?? ``;
    
  });
