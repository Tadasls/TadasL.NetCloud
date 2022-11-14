
const oraiUrl = "https://api.open-meteo.com/v1/forecast?latitude=54.8236&longitude=24.1673&hourly=temperature_2m";


const optionsOrams = {
    method: 'get',
    dataType: "jsonp",
    headers: {   'Access-Control-Allow-Origin': '*',
        'Accept': 'application/json',   
             'Content-Type': 'application/json'  
    }
  };


  gautiOrus();

function gautiOrus(obj){
    fetch(oraiUrl, optionsOrams)
    .then( response => response.json())
    .then( data => {
        console.log(data);
        orai.innerHTML +=` <br> Vardas :  ${data.results[obj].name}`;

    console.log(data.results[obj]);
    });
}













const url5 = 'https://swapi.dev/api/starships';
const url2 = 'https://swapi.dev/api/people/';
const url3 = 'https://swapi.dev/api/vehicles/';
const url4 = 'https://swapi.dev/api/planets/';
const url = "https://swapi.dev/api/species";












const options = {};
const rezult = {};


function gautiDuomenis(obj){
    fetch(url5, options)
    .then( response => response.json())
    .then( data => {
    tekstas.innerHTML +=` <br> Vardas :  ${data.results[obj].name}`;
    tekstas.innerHTML +=` <br> Modelis:  ${data.results[obj].model}`;
    tekstas.innerHTML +=` <br> Gamintojas:   ${data.results[obj].manufacturer}`;

    console.log(data.results[obj]);
    });
}

function gautiDuomenis2(obj){
    fetch(url2, options)
    .then( response => response.json())
    .then( data => {
    tekstas2.innerHTML +=` <br> Vardas :  ${data.results[obj].name}`;
    tekstas2.innerHTML +=` <br> aukstis:  ${data.results[obj].height}`;
    tekstas2.innerHTML +=` <br> metai:   ${data.results[obj].birth_year}`;

    console.log(data.results[obj]);
    });
}

function gautiDuomenis3(obj){
    fetch(url3, options)
    .then( response => response.json())
    .then( data => {
    tekstas3.innerHTML +=` <br> Vardas :  ${data.results[obj].name}`;
    tekstas3.innerHTML +=` <br> modelis:  ${data.results[obj].model}`;
    tekstas3.innerHTML +=` <br> gamintojas:   ${data.results[obj].manufacturer}`;

    console.log(data.results[obj]);
    });
}

function gautiDuomenis4(obj){
    fetch(url4, options)
    .then( response => response.json())
    .then( data => {
    tekstas4.innerHTML +=` <br> Vardas :  ${data.results[obj].name}`;
    tekstas4.innerHTML +=` <br> apsisukimo periodas:  ${data.results[obj].rotation_period}`;
    tekstas4.innerHTML +=` <br> orbitosperiodas:   ${data.results[obj].orbital_period}`;

    console.log(data.results[obj]);
    });
}


function gautiDuomenis5(obj){
    fetch(url, options)
    .then( response => response.json())
    .then( data => {
    tekstas5.innerHTML +=` <br> Vardas :  ${data.results[obj].name}`;
    tekstas5.innerHTML +=` <br> classification :  ${data.results[obj].classification}`;
    tekstas5.innerHTML +=` <br> designation:   ${data.results[obj].designation}`;
    tekstas5.innerHTML +=` <br> average_height:   ${data.results[obj].average_height}`;
    tekstas5.innerHTML +=` <br> homeworld:   ${data.results[obj].homeworld}`;


    console.log(data.results[obj]);
    });
}



gautiDuomenis5(0);
console.log(`veiksmas`);
for (let i = 0; i < 10; i++) {
    gautiDuomenis5(i);
}





const loadDataSimple = () => {
    fetch(url)
    //.then( response => response.json()  )
    .then((res) => {
      if (res.ok) {
        console.log(res);
        return res.json();
      } else {
        console.log("Got error. Status : " + res.status);
      }
    })
    .then((data) => console.log(data.results[2]));
};

const loadDataAsync = async () => {
    try{
        console.log("traukiam duomenis");
        const response = await fetch (url);
        console.log("ats gautas");
        const data = await response.json();
        console.log(data);
    } catch (error) {
        console.log(error);
    }
}
loadDataAsync();
console.log("mes dabar esam cia");

const showData = (data) => {

}

const loadMultiData = async () =>{
    const url1 = 'https://reqres.in/api/users?page=1'
    const url2 = 'https://reqres.in/api/users?page=2'
    const url3 = 'https://reqres.in/api/users?page=3'

    const responses = await Promise.all( [ 
        fetch(url1), 
        fetch(url2), 
        fetch(url3) 
    ]);

    const multiPromises = responses.map( r =>  r.json() );
    const finalData = await Promise.all( multiPromises );
    processData( finalData );
}

const processData = (arr) => {
    //processing arr as data
}

loadDataAsync();
console.log( "Mes dabar esam cia");

 showData = data => {
    console.log(data);
}