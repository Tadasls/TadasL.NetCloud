const url = 'https://localhost:7068/Knygynas';
const options = {
    method: 'get'
}

const response = {};

function loadData() {
    fetch(url, options)
    .then((response) => response.json())
    .then((a) => {
        console.log(a);
        const menuContainer = document.getElementById('menu-items');
        let htmlMenuItem = '';

        a.forEach(element => {
            console.log(element);
            let htmlElement = 
            `<article class="menu-item">
                <section class="menu-item-picture">
                    <img src="placeholder-150.bmp" alt="placeholder image">
                </section>
                <section class="menu-item-info">
                    <section class="menu-item-name">
                        <h3>${element.pavadinimasIrAutorius}</h3>
                    </section>
                    <section class="menu-item-desc">
                      laidybos metai:   ${element.leidybosMetai} - ir knygu kiekis  ${element.knyguKiekis} 
                    </section>
                    <section class="menu-item-price">
                        Kiekis: ${element.id}
                    </section>
                </section>
            </article>`;
            htmlMenuItem += htmlElement;
        });

        menuContainer.innerHTML = htmlMenuItem;
    })
}

loadData();