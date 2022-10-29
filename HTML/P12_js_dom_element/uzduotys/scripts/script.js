function show(index) {
  const buttons = document.querySelectorAll('.btn');
  for (const btn of buttons) {
    btn.classList.remove('btn-hover');
  }
  buttons[index].classList.add('btn-hover');




  document.querySelector('#pavadinimas').innerHTML =
    receptai[index].pavadinimas;
  document.querySelector('#paruosimas').innerHTML = receptai[index].paruosimas;
  document.querySelector('#ingredientai').innerHTML =
    receptai[index].ingredientai;
  document.querySelector('#paveikslelis').src = receptai[index].paveikslelis;


  //alergenai
  document.querySelector('#alergenai').innerHTML = '';
  if (document.getElementsByClassName('milk').length > 0) {
    document.querySelector('#alergenai').innerHTML += `<div class="box-3">
    <img src="${alergenai[0]}" alt="laktoze" width="60" />
    </div>`;
  }
  if (document.getElementsByClassName('flour').length > 0) {
    document.querySelector('#alergenai').innerHTML += `<div class="box-3">
    <img src="${alergenai[1]}" alt="laktoze" width="60" />
    </div>`;
  }
  if (document.getElementsByClassName('egg').length > 0) {
    document.querySelector('#alergenai').innerHTML += `<div class="box-3">
        <img src="${alergenai[2]}" alt="laktoze" width="60" />
        </div>`;
  }


  const ingredientai = document.querySelectorAll('#ingredientai');
  for (const li of ingredientai) {
    for (const link of links) {
      if (li.innerHTML.includes(link.name)) {
        li.innerHTML = li.innerHTML.replace(
          link.name,
          `<a href="${link.href}">${link.name}</a>`
        );
      }
    }
  }
}


const links = [
  { name: 'pienas', href: 'https://lt.wikipedia.org/wiki/Pienas' },
  { name: 'kakavos pudra', href: 'https://lt.wikipedia.org/wiki/Kakava' },
  { name: 'cukrus', href: 'https://lt.wikipedia.org/wiki/Cukrus' },
  { name: 'sviestas', href: 'https://lt.wikipedia.org/wiki/Sviestas' },
  { name: 'kakava', href: 'https://lt.wikipedia.org/wiki/Kakava' },
  { name: 'druska', href: 'https://lt.wikipedia.org/wiki/Druska' },
];


const receptai = [
  {
    pavadinimas: `Karšta kakava`,
    paruosimas: `<li>
    Pirmiausia moliniame puodelyje šaukštu gerai išmaišykite vieną
    valgomąjį šaukštą kakavos su vienu valgomuoju šaukštu cukraus.
  </li>
  <li>
    Pripilkite vieną valgomąjį šaukštą pieno ir labai gerai
    išmaišykite, iki kol gausite vientisą masę, tepamo sūrio tirštumo.
  </li>
  <li>
    Tada pripilkite dar 100 mililitrų pieno. Dar kartą viską gerai
    išmaišykite, plūduriuojančius tirštos kakavos gumuliukus šaukštu
    sutraiškykite į puodelio sienelę.
  </li>
  <li>
    Po to mišinį supilkite į nedidelį puodą, supilkite likusį pieną ir
    virš vidutiniškos liepsnos virinkite visą laiką maišydami šaukštu.
    Reikia būti pasiruošus puodą nukelti nuo liepsnos, kai maždaug po
    10 minučių virimo mišinys užvirs, tai yra pakils iki puodo kraštų
  </li>
  <li>
    Per smulkų sietelį karštą kakavą pilkite į du molinius puodelius
  </li>`,
    ingredientai: `<li class='milk'>pienas: 500 mililitrų</li>
                   <li>kakavos pudra (be priemaišų): 1 valgomojo šaukšto</li>
                   <li>cukrus: 1 valgomojo šaukšto</li>`,
    paveikslelis: `kakava.jpg`,
  },
  {
    pavadinimas: `Tinginys su pienu`,
    paruosimas: `<li>Pirmiausia sausainius sutrupinkite į didelį dubenį.</li>
    <li>
      Tada nedideliame puode išlydykite sviestą ant vidutinės kaitros.
    </li>
    <li>
      Supilkite pieną, suberkite cukrų, kakavą, vanilinį cukrų bei druską.
      Maišykite, kol masė pradės virti.
    </li>
    <li>
      Virkite maždaug 3-4 minutes ant silpnos kaitros nuolatos maišydami.
      Masė per tą laiką šiek tiek sutirštėja.
    </li>
    <li>Tuomet iš karto užpilkite ant sausainių ir gerai išmaišykite.</li>
    <li>Sausainių masę palikite šiek teik atvėsti.</li>
    <li>
      Kai sausainių masė šiek tiek atvės, ant stalviršio patieskite maistinę
      plėvelę ir sudėkite sausainių tešlą bei suformuokite ritinį.
    </li>
    <li>
      Tuomet sausainius susukite į plėvelę, gerai užspauskite plėvelę, kad
      neliktų oro tarpelių, užsukite ritinio galus ir dėkite į šaldytuvą
      stengti mažiausiai porai valandų arba dar geriau per visą naktį.
    </li>
    <li>Kai jau tinginys sustingsta, supjaustykite griežinėliais</li>`,
    ingredientai: `<li>sausainiai: 400 gramų</li>
                   <li>sviestas: 150 gramų</li>
                   <li class='milk'>pienas: 180 mililitrų</li>
                   <li >cukrus: 70 gramų</li>
                   <li>kakava: 4 valgomųjų šaukštų</li>
                   <li>vanilinis cukrus: 1 arbatinio šaukštelio (arba vanilės ekstraktas)</li>
                   <li>druska: žiupsnelio
    </li>`,
    paveikslelis: `tinginys.jpg`,
  },
  {
    pavadinimas: `Brownie`,
    paruosimas: `<li>
    Pirmiausia įkaitinkite orkaitę iki 175 laipsnių temperatūros ir
    pasisveriame ingredientus. Nuo šių sausainių gaminimo laiko labai
    priklausys jų tekstūra, rezultatas, tad reikėtų nesėdėti rankų
    sudėjus.
  </li>
  <li>
    Garų vonelėje išlydykite šokoladą su sviestu. Kol jie lydosi, į didelį
    dubenį muškite kiaušinį ir berkite abiejų rūšių cukrų. Plakite dideliu
    galingumu apie 5 minutes.
  </li>
  <li>
    Atskirame dubenėlyje sumaišykite sausus ingredientus. Šokolado masė
    jau turi būti paruošta, tad jeigu dar nepraėjo 5 plakimo minutės,
    tiesiog paliekame šokoladą šiek tiek pravėsti.
  </li>
  <li>
    Sumažiname plaktuvo galingumą ir po truputį pilame jau pravėsusią
    masę.
  </li>
  <li>
    Kai jau viskas patampa vientisa, pakeičiame kombaino antgalį, į skirtą
    tirštesnei tešlai (jeigu naudosite įprastą plaktuvą, šį žingsnį
    tiesiog praleidžiame) ir plakdami labai lėtai, po truputį beriame
    sausų ingredientų mišinį.
  </li>
  <li>
    Mūsų brownie sausainių tešla jau paruošta! Neišsigąstame, kad ji
    tikrai skystesnė nei įprastos sausainių masės, bet tai būtent ta
    priežastis, kuri suteiks sausainiams tą labai gražų suskeldėjusį raštą
    ir labai minkštą bei tąsų vidų.
  </li>
  <li>
    Tada į kepimo skardą, išklotą su kepimo popieriumi, dėkite po norimą
    kiekį tešlos. Aš dedu po vieną arbatinį šaukštelį su nemenku kaupu,
    bet jūs galite kepti tiek didesnius, tiek mažesnius sausainius - pagal
    savo norus ir pageidavimus.
  </li>
  <li>Dėkite į jau įkaitintą orkaitę ir kepkite apie 10-12 minučių.</li>`,
    ingredientai: `<li>70% juodas šokoladas: 100 gramų</li>
                   <li>sviestas: 62 gramų</li>
                   <li>cukrus: 75 gramų</li>
                   <li>rudas cukrus: 50 gramų</li>
                   <li class='egg'>kiaušiniai: 1</li>
                   <li class='flour'>miltai: 65 gramų</li>
                   <li>kakava: 11 gramų</li>
                   <li>kepimo milteliai: 0,5 arbatinio šaukštelio</li>
                   <li>druska: žiupsnelio</li>`,
    paveikslelis: `brownie.jpg`,
  },
];

const alergenai = [`lacteos.png`, `gluten.png`, `egg.png`];
