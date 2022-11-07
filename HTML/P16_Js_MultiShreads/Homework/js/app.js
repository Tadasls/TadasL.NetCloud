const networkRequest = () => {
    setTimeout(() => {
        uzduociuLaukas.innerHTML += '<br>Async Code';
    }, 2000);
};

uzduociuLaukas.innerHTML += '<br>Hello World';
networkRequest();
uzduociuLaukas.innerHTML += '<br>The End';

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

taimerioMygtukas.addEventListener('click', startas);

//antras

const paragrafas = document.querySelector('p');

function messageUserAboutClick() {
    alert('Žirgas Krito, Reikalinga Skubi pagalba!');
    paragrafas.style.backgroundColor="red";
}
function antrasPranesimas() {
    alert('Raitelis Sveikas!');
    paragrafas.style.backgroundColor="white";
}

antrasMygtukas.addEventListener('click', messageUserAboutClick); 
treciasMygtukas.addEventListener('click', function() { 
        setTimeout(antrasPranesimas, 1000);
});


//antras
