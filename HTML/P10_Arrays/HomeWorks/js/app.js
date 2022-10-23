function helloWorld() {

    let worldText = 'World';
    console.log("Hello World!");
    console.log(`Hello ${worldText}!`);
}

helloWorld();



function throwDie() {
    let roll = Math.floor(Math.random() * 6) + 1;
    console.log(`Die was rolled: ${roll}`);
}
throwDie();
throwDie();
throwDie();


let usserName = prompt("Įveskite UsserName:");
let password = prompt("Įveskite Password:");

let slaptazodzioIlgis = password.length;
if (slaptazodzioIlgis === 8) { 
    
}
console.log(`slaptazodzio ilgumas yra  ${slaptazodzioIlgis}`);
