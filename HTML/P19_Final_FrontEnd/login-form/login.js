const logFirstName = document.querySelector('#logfirstName');
const logLastName = document.querySelector('#loglastname');
const loginFormSbmBtn = document.querySelector('#login_form_submit');
const url = 'https://testapi.io/api/Tadasls/resource/TLSusersDB';
let prisijungimas = false;
const options = {
  method: 'get',
  headers: {      
    'Accept': 'application/json',
    'Content-Type': 'application/json'
  }
}

// local conection

function patikrintiVartotojus(){
  fetch('https://localhost:7125/api/user/get')
     .then((response) => response.json())
    .then((data) => 
    {
      data.forEach(user => {
        if(user.userName.toLowerCase() === logFirstName.value.toLowerCase() && user.userLastname.toLowerCase() === logLastName.value.toLowerCase())
        {console.log(`vardas ${user.userName} ir pavarde ${user.userLastname} ir email ${user.userEmail}`);
        window.alert(`Sveiki prisijunge ${user.userName} `);
       
        const vartotojoDuomenys = {
          ID: user.id,
          regUserName: user.userName,
          regUserLastname: user.userLastname,
          regUserEmail: user.userEmail,
          // Created: user.createdAt.slice(0, 10) + ' ' + user.createdAt.slice(11, 19),
          // Updated: user.updatedAt.slice(0, 10) + ' ' + user.updatedAt.slice(11, 19)
      };
      saveLocalFormData(vartotojoDuomenys);
  
        sessionStorage.clear();
        window.location = '../todo/todo.html';
        prisijungimas = true;
  
       } 

     
      });
      if (!prisijungimas){
        window.alert(`Toks vartotojas Neegzistuoja `);
         }
    //  Alert.on("Tokio Userio Nėra !");
  

  })
  .catch((klaida) => console.log(klaida));
}

// new local iki cia




//online db

// function patikrintiVartotojus(){
// fetch('https://testapi.io/api/Tadasls/resource/TLSusersDB')
//   .then((response) => response.json())
//   .then((userData) => 
//   {
//     userData.data.forEach(user => {
//       if(user.userName.toLowerCase() === logFirstName.value.toLowerCase() && user.userLastname.toLowerCase() === logLastName.value.toLowerCase())
//       {console.log(`vardas ${user.userName} ir pavarde ${user.userLastname} ir email ${user.userEmail}`);
//       window.alert(`Sveiki prisijunge ${user.userName} `);
     
//       const vartotojoDuomenys = {
//         ID: user.id,
//         regUserName: user.userName,
//         regUserLastname: user.userLastname,
//         regUserEmail: user.userEmail,
//         Created: user.createdAt.slice(0, 10) + ' ' + user.createdAt.slice(11, 19),
//         Updated: user.updatedAt.slice(0, 10) + ' ' + user.updatedAt.slice(11, 19)
//     };
//     saveLocalFormData(vartotojoDuomenys);

//       sessionStorage.clear();
//       window.location = '../todo/todo.html';
//       prisijungimas = true;

//      } 
     
//     });
//       if (!prisijungimas){
//         window.alert(`Toks vartotojas Neegzistuoja `);
//          }
//     //  Alert.on("Tokio Userio Nėra !");
  

//   })
//   .catch((klaida) => console.log(klaida));
// }


loginFormSbmBtn.addEventListener("click", (e) => {
    e.preventDefault();
     patikrintiVartotojus(); 
  });
  


  const saveLocalFormData = (obj) => {
    localStorage.setItem('UserData', JSON.stringify(obj)); 
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

  document.addEventListener('DOMContentLoaded', () => {
    const o = Object.assign({}, JSON.parse(localStorage.getItem('UserData')));
    logFirstName.value = o.regUserName ?? ``;
    logLastName.value = o.regUserLastname ?? ``;
  });



//   function CustomAlert(){
//     this.on = function(alert){
//         var winW = window.innerWidth;
//         var winH = window.innerHeight;

//         alertoverlay.style.display = "block";
//         alertoverlay.style.height = window.innerHeight+"px";
//         alertbox.style.left = (window.innerWidth/3.5)+"pt";
//         alertbox.style.right = (window.innerWidth/3.5)+"pt";
//     alertbox.style.top = (window.innerHeight/10)+"pt";
//         alertbox.style.display = "block";
//         document.getElementById('alertboxhead').innerHTML = "Pranešimas didelis ir raudonas :";
//         document.getElementById('alertboxbody').innerHTML = alert;
//         document.getElementById('alertboxfoot').innerHTML = '<button onclick="Alert.off()">OK</button>';
//     }
//     this.off = function(){
//         document.getElementById('alertbox').style.display = "none";
//         document.getElementById('alertoverlay').style.display = "none";
//     }
// }
// var Alert = new CustomAlert();




