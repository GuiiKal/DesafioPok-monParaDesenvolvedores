function pk() {
  let url = 'https://pokeapi.co/api/v2/pokemon/25/';

  //testando a temeperatura que corresponde com cada pokemon - não funciona desse jeito :(
  //var t = document.getElementById('lblTemp').nodeValue;
  //if (t < 5) {
  //  url = 'https://pokeapi.co/api/v2/pokemon/583/';
  //}
  //else if (t >= 5 && t < 10) {
  //  url = 'https://pokeapi.co/api/v2/pokemon/87/';
  //}
  //else if (t >= 12 && t < 15) {
  //  url = 'https://pokeapi.co/api/v2/pokemon/91/';
  //}
  //else if (t >= 15 && t < 21) {
  //  url = 'https://pokeapi.co/api/v2/pokemon/131/';
  //}
  //else if (t >= 23 && t < 27) {
  //  url = 'https://pokeapi.co/api/v2/pokemon/220/';
  //}
  //else if (t >= 27 && t < 33) {
  //  url = 'https://pokeapi.co/api/v2/pokemon/215/';
  //}
  //else if (t > 33) {
  //  url = 'https://pokeapi.co/api/v2/pokemon/144/';
  //}
  //else {
  //  alert('erro');
  //}
  //fim dos testes

  //códigos para aparecer o pokémon na tela 
  fetch(url)
    .then((Response) => {
      return Response.json();
    })
    .then((data) => {
      console.clear();
      console.log(data);
      document.getElementById('nomePok').innerHTML = data['name'];
      let img = data['sprites']['front_default'];
      document.getElementById('imgPok').setAttribute('src', img);
    })
    .catch((erro) => {
      alert("Erro: " + erro);
    })

}

document.getElementById('btnSubmit').onclick = pk;
