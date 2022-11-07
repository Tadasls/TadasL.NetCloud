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


