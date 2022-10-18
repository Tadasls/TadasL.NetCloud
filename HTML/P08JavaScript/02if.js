console.log(`hello Conditional Statements----`)

const hour = 20;
let greeting = 'good night';
if(hour < 18){
    greeting = 'good day';
} else {
    greeting = 'good night';
 }

console.log(greeting);

if(hour <10 ) {
    greeting = "Good morning";
} else if (hour > 20) { 
    greeting = "Good day"; 
} 
console.log(greeting);

let day ;

if (day) { greeting = 'good day';
} else {
    greeting = 'not day';
}


// npm install nodemon -g

let a = window.prompt("iveskite a reiksme");
let b = window.prompt("iveskite b reiksme");

let palyginimas = 'skaiciai lygus';



if (a === b){
    palyginimas = 'a lygus b';
 } else if(+ a > + b)
 {
     palyginimas = 'a didesnis uz b';
 } else 
 {
     palyginimas = 'b didesnis uz a';
 } 



 console.log(`palyginimas ${palyginimas}`);