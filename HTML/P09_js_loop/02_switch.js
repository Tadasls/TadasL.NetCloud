console.log('Hello switch');

let data = new Date('1983-11-09');


switch (data.getDay()) {
    case 0:
        day = 'Sekmadienis'
        break;
    case 1:
        day = 'Pirmadienis'
        break;
    case 2:
        day = 'Antradienis'
        break;
    case 3:
        day = 'Treciadienis'
        break;
    case 4:
        day = 'Ketvirtadienis'
        break;
     case 5:
        day = 'Penktadienis'
        break;
    case 6:
        day = 'Šeštadienis'
        break;
    default:
    day = '';
        break;
}

console.log(`day = ${day}`);


//----------------------------------


let d = data.getDay();

switch (data.getDay()){
    case 1:
    case 2:
    case 3:
    case 4:
    case 5:
        txt = "Darbo diena";
        break;
    case 0:
    case 6:
         txt = "savaitgalis";
         break;


}
console.log(`day = ${typeof d}`);
console.log(`day = ${txt}`);


//-------------
console.log(`--------------------`);

let x = '0';
switch (x) {
    case 0:
        txt = 'isjungta';
        break;

        case 1:
            txt = 'ijungta';
            break;
    
            case '0':
                txt = 'nulis';
                break;
        

    default:
        txt= 'nezinoma';
        break;
}

console.log(`reiksme = ${txt}`);



let str = '';
for (let i = 0; i<=16; i+=4){
str += i;
str +=' ';
}
console.log(` ${str}`);