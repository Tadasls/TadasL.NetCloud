const networkRequest = () => {
  setTimeout(() => {
    uzduociuLaukas.innerHTML += "<br>Async Code";
  }, 2000);
};

uzduociuLaukas.innerHTML += "<br>Hello World";
networkRequest();
uzduociuLaukas.innerHTML += "<br>The End";


//extra
const startas = () => {
  setTimeout(() => {
    lenktyniuLaukas.innerHTML += `<br>Dėmesio!`;
  }, 1000);
  setTimeout(() => {
    lenktyniuLaukas.innerHTML += `<br>Pasiruosti!!`;
  }, 3000);
  setTimeout(() => {
    lenktyniuLaukas.innerHTML += `<strong><br>Startas!!!</strong>`;
  }, 5000);
 
 
};





taimerioMygtukas.addEventListener("click", startas);

//antras

const paragrafas = document.querySelector("p");

function messageUserAboutClick() {
  paragrafas.innerHTML = " Krites zirgas ";
  paragrafas.style.backgroundColor = "red";
  alert("Žirgas Krito, Reikalinga Skubi pagalba!");
}
function antrasPranesimas() {
  alert("Raitelis Sveikas!");
  paragrafas.innerHTML = " Raitelis ir zirgas sveiki ";
  paragrafas.style.backgroundColor = "white";
}

antrasMygtukas.addEventListener("click", messageUserAboutClick);

treciasMygtukas.addEventListener("click", function () {
  paragrafas.innerHTML = " Raitelis ir zirgas sveiki ";
  setTimeout(antrasPranesimas, 1000);
});

//trecias
let visiIngredientaiToppings = [
  "flour",
  "ketchup",
  "onion",
  "powder",
  "sugar",
  "cheese",
  "mushroom",
  "pepper",
  "mozzarella",
  "yeast",
  "water",
];

let pasiriktasIngredientas = "ananasas";

let prom = new Promise((resolve, reject) => {
  if (visiIngredientaiToppings.includes(pasiriktasIngredientas)) {
    resolve(`rastas : ${pasiriktasIngredientas} tai labai blogai :)  `);
  } else {
    reject(`Gerai nes cia nera :${pasiriktasIngredientas} `);
  }
});

let err = "klaidos pranesimas";
prom
  .then((res) => {
    console.log(res);
  })
  .catch((err) => {
    console.log(err);
  });

//ketvirtas uzd

function showTime() {
  let time = new Date();
  let hour = time.getHours();
  let min = time.getMinutes();
  let sec = time.getSeconds();
  am_pm = "AM";

  if (hour > 12) {
    hour -= 12;
    am_pm = "PM";
  }
  if (hour == 0) {
    hr = 12;
    am_pm = "AM";
  }

  // hour = hour < 10 ? "0" + hour : hour;
  min = min < 10 ? "0" + min : min;
  sec = sec < 10 ? "0" + sec : sec;

  let currentTime = hour + ":" + min + ":" + sec + " " + am_pm;
  document.getElementById("laikrodis").innerHTML = currentTime;
}

taimerioStartas.addEventListener("click", () => {
  taimerioStartas.disabled = true;
});

function stop() {
  clearInterval(myInterval);
}

function start() {
  const laikrodis = setInterval(showTime, 1000);
}

taimerioStop.addEventListener("click", () => {
  taimerioStartas.disabled = false;

  let laikas = new Date();
  document.getElementById("laikrodis").innerHTML = laikas.toLocaleTimeString();
  localStorage.setItem(`Irasytas laikas ${laikas.toLocaleTimeString()} Time: `, laikas.toLocaleTimeString());
  pranesimasPrieLaikrodzioIrasymo.innerHTML = `laikas įrašytas ${laikas.toLocaleTimeString()}`;
});

PrintTimeRecords.onclick = () => {
  const keys = Object.keys(localStorage);
  const lst = document.querySelector("#lst_loop");
  for (const key of keys) {
    lst.innerHTML += `<li>${key}: ${localStorage.getItem(key)}</li>`;
  }
};
