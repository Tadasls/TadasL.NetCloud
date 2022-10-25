fname.addEventListener('change', parodytiVardaPavarde);
cardNumber.addEventListener('change', parodytiKortelesSkaicius);
datemax.addEventListener('keydown', parodytiData);


function parodytiVardaPavarde() {
  if (fname.value.length=19) {
    full_name.innerHTML = `${fname.value}`;
  }
  
}

function parodytiKortelesSkaicius() {
  kort_skaiciai.innerHTML = `${cardNumber.value}`;
}

function parodytiData() {
  Kort_galio_data.innerHTML = `${datemax.value}`;
}

const galimaMoketi = fname.value.length === 0 || cardNumber.value===0;
document.querySelector('#Pay').disabled = galimaMoketi;


const sukurtiJasona = (e) => {
  e.preventDefault(e);
  const formElem = e.target;
  const formData = new FormData(formElem);
  const data = Object.fromEntries(formData);
  console.log(data);
};


frm_registration.addEventListener('submit', sukurtiJasona);