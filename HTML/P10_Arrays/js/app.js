// Creating arrays
let students = []; // Most common syntax
let students2 = new Array();
let colors = ['red', 'orange', 'green'];
let colors2 = new Array('red', 'orange', 'green');
let lottoNumbers = [19,22,56.80,12,51];
let stuff = [true, 68, 'dog', null, undefined, NaN];
let shoppingList = ['cereal', 'cheese', 'ice'];

console.log(colors);
console.log(colors[2]);
console.log(colors.length);
console.log(`Color count: ${colors.length}`);
console.log(`Last lotto number: ${lottoNumbers[lottoNumbers.length]}`);
console.log(`Last lotto number: ${lottoNumbers[lottoNumbers.length-1]}`);


// EXERCISE 1

console.log();
console.log("Exercise 1");

let exerciseMovieList = ["Lord of The Rings", "Star Wars", "Green Mile", "RRR", "Samaritan"];

// console.log(exerciseMovieList[0]);
// console.log(exerciseMovieList[1]);
// console.log(exerciseMovieList[2]);
// console.log(exerciseMovieList[3]);
// console.log(exerciseMovieList[4]);

for(let movie of exerciseMovieList) {
    console.log(movie);
}

// EXERCISE 1 DONE

// EXERCISE 2

console.log();
console.log("Exercise 2");

exerciseMovieList[4] = "Inception"; // Updating existing element
exerciseMovieList[5] = "The Godfather"; // Adding new element
exerciseMovieList[exerciseMovieList.length] = "The Dark Knight"; // Adding new element
console.log(exerciseMovieList.length);
for (let movie of exerciseMovieList) {
    console.log(movie);
}

// EXERCISE 2 DONE

// EXERCISE 3

console.log();
console.log("Exercise 3");

exerciseAnimals = ['Bear', 'Camel', 'Donkey', 'Cat', 'Dog', 'Zebra', 'Deer'];

for (let i = 0; i < exerciseAnimals.length; i++) {
    console.log(exerciseAnimals[i]);
}

for(let animal of exerciseAnimals) {
    console.log(animal);
}

// EXERCISE 3 DONE

// EXERCISE 4

// let candies = []; // Pasidometi kodel nesuveikia
let candies = new Array();
let isExercise4On = false;

if(isExercise4On) {
    for (let i = 0; i < 3; i++) {
        let price = prompt("Įveskite kainą:");
        let name = prompt("Įveskite pavadinimą:");
        let weight = prompt("Įveskite svorį:");
        let candy = [price, name, weight];
        // candies[i] = `${price}$ ${name} ${weight} grams`;
    
        // candies[i][0] = price;
        // candies[i][1] = name;
        // candies[i][2] = weight;
    
        console.log(candy);
        candies[i] = candy;
    }
    
    for(let candy of candies) {
        console.log(candy);
    }
}


console.table(candies);

// EXERCISE 4 DONE

colors[1] = 'purple';
colors[3] = 'blue';
colors[colors.length] = 'teal';
colors[colors.length] = 'magenta';
let colorLength = colors.length;
colors[colorLength] = 'pink';


// Reading array elements using loops
console.log();
console.log("Looping through elements".toUpperCase());
for (let i = 0; i < colorLength; i++) {
    console.log((colors[i]));
}

for(let color of colors) {
    console.log(color);
}

let colorIndex = 1;
for(let color of colors) {
    console.log(`${colorIndex}. ${color}`);
    colorIndex++;
}

// Mes negalime atnaujinti naudodami foreach, nes tai keičia būsena
// dar nespėjus perskaityti visų reikšmių
// colorIndex = 1;
// for(let color of colors) {
//     color = `${colorIndex}. ${color}`;
//     colorIndex++;
// }

colorIndex = 1;
for(let i = 0; i <= colorLength; i++) {
    colors[i] = `${colorIndex}. ${colors[i]}`;
    colorIndex++;
}

// Mes negalime atnaujinti reikšmių kada naudojame foreach
// net jei duomenų tipai yra struct/number type
let lottoNumAddNo = 1;
for(let lottoNo of lottoNumbers) {
    lottoNo += lottoNumAddNo;
    console.log(lottoNo);
}

lottoNumbers.forEach((item, index, array) => {
    console.log(`a[${index}] = ${item}`);
});

const logArrayElements = (element, index, array) => {
    console.log(`a[${index}] = ${element}`);
};