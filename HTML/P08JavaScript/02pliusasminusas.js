


// let x = 3;
// let y = -7;
// let z = 2;

let x = window.prompt("iveskite x reiksme");
let y = window.prompt("iveskite y reiksme");
let z = window.prompt("iveskite z reiksme");

let t =0;

if (+x < 0){
    pirmasneigiamas = 'x yra neigiamas';
    console.log(`atsakymas yra ${pirmasneigiamas}`);
    t++
 } 

 if((+y < 0))
 {
    antrasneigiamas = 'Y yra neigiamas';
    console.log(`atsakymas yra ${antrasneigiamas}`);
    t++
 } 
 if((+z < 0))
 {
    treciasneigiamas = 'z yra neigiamas';
    console.log(`atsakymas yra ${treciasneigiamas}`);
    t++
 } 
 console.log(`viso neigiamu yra ${t}`);
