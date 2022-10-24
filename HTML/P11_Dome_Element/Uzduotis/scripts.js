// function receptas1() {
//     const list_of_li = document.getElementsByClassName('milk');
//     for (const li of list_of_li) {
//       if (li.classList.contains('pretty_milk')) {
//         li.classList.remove('pretty_milk');
//       } else {
//         li.classList.add('pretty_milk');
//       }
//     }
//   }


  function receptas2() {
    const div = document.getElementsByClassName('Item Alergens');
    div.innerHTML += `<div class="Item Name">KAZKAS</div>`;
  }

  function receptas3() {
    const div = document.getElementsByTagName('Item Alergens')[0];
    div.innerHTML += `<div class="drink milk">Milk</div>`;
  }

  function receptas1() {
    const div = document.getElementsByTagName('Item Alergens')[0];
    const kavos_li = div.getElementsByTagName('div')[0];
    kavos_li.innerHTML += ` Kitas gerimas`;
  }