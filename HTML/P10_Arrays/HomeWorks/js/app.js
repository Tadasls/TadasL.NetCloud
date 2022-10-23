
// IsPassWordValid();

function IsPassWordValid(userName, passWord){

    userName = prompt("Įveskite UsserName:");
    passWord = prompt("Įveskite Password:");
           
    let slaptazodzioIlgis = passWord.length;
    let arSutapimas = passWord == userName;
    let passA = passWord.trim();
    let tarpuSkaicius = passWord.length - passA.length;
    
    slaptazodzioIlgis !== 8 
    ? alert("Slaptazodis per Trumpas/PerIlgas")
    : arSutapimas === true 
    ? alert("Slaptazodis negali buti UsserName")
    : tarpuSkaicius >= 1
    ? alert("Slaptazodyje negali buti tusti tarpai")
    : alert("Sveikiname Prisijungus");
        
}

let array = [19,22,56.80,12,51, 100];
let vidurkioSuma = 0;
function GetAverageOfArray(array){
   


    for(let skaicius of array) {
       vidurkioSuma = skaicius + vidurkioSuma;
    }

 let vidurkis = vidurkioSuma / array.length;
 console.log(vidurkis.toFixed(2));
}
GetAverageOfArray(array);



let show = function() {
    console.log(`Anononymous function`);
};

let add = function(a,b) {
    return a+b;
};

show();
console.log(add(2,2));


// let param1 = 5;
// let param2 = 7;
// const getData = console.log(param1,param2);

console.log(`tadas`);


let cardType = ['Clubs', 'Spades', 'Hearts', 'Diamonds'];
let cardValue = ['A','2','3','4','5','6','7','8','9','10','J','Q','K'];


function pickOne(cardType,cardValue) {
    
    let randomCardType = cardType[Math.floor(Math.random() * cardType.length)];
    let randomCardValue = cardValue[Math.floor(Math.random() * cardValue.length)];
    console.log(randomCardType);
    let vaizdas = randomCardValue.replace('A', 'Ace').replace('J', 'Joker').replace('Q', 'Queen').replace('K', 'King');
    console.log(`You drew ${vaizdas} of ${randomCardType}   `);
}        

pickOne(cardType,cardValue);
