let timeoutId;

async function searchCharacters() {
    const searchTerm = document.getElementById("searchTerm").value;
    clearTimeout(timeoutId); // Limpiar el temporizador si el usuario sigue escribiendo

    // Esperar 500 ms después de que el usuario haya dejado de escribir antes de iniciar la búsqueda
    timeoutId = setTimeout(async () => {
        const response = await fetch(`https://rickandmortyapi.com/api/character/?name=${searchTerm}`);
        const data = await response.json();
        populateCharacterCards(data.results);
    }, 500);
}

function populateCharacterCards(characters) {
    const characterContainer = document.getElementById("characterContainer");
    characterContainer.innerHTML = ""; // Limpiar el contenedor antes de agregar nuevas tarjetas de personaje

    characters.forEach(character => {
        const card = document.createElement("div");
        card.classList.add("col-md-4", "mb-4", "character-card");
        card.innerHTML = `
                <div class="card shadow rounded text-center bg-dark text-light">
                    <img src="${character.image}" class="card-img-top" alt="${character.name}">
                    <div class="card-body">
                        <h5 class="card-title">${character.name}</h5>
                        <p class="card-text">${character.status} - ${character.species}</p>
                        <p class="card-text">${character.gender}</p>
                        <p class="card-text">Origin - ${character.origin.name}</p>
                        <p class="card-text">Location - ${character.location.name}</p>
                    </div>
                </div>
            `;
        characterContainer.appendChild(card);
    });
}

async function loadPage(page) {
    const searchTerm = document.getElementById("searchTerm").value;
    const response = await fetch(`https://rickandmortyapi.com/api/character/?name=${searchTerm}&page=${page}`);
    const data = await response.json();
    populateCharacterCards(data.results);
}