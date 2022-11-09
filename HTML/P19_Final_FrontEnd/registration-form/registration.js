const newRegForm = document.querySelector("#new-registration-form");
const newRegFormSbmBtn = document.querySelector("#new-registration-form-submit");

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
    console.log(data);
}

newRegFormSbmBtn.addEventListener("click", (e) => {
  e.preventDefault();
  sendRegData();

});





