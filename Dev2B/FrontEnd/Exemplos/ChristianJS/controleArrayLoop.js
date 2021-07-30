const aprovados = ["Agatha", "Aldo", "Daniel", "Raquel"];

aprovados.forEach(function (valor, indice, array) {
  console.log(valor);
  console.log(indice);
  console.log(array);
});

const nums = [1, 2, 3, 4, 5];

let resultado = nums.map(function (elemento) {
  return elemento * 2;
});

console.log(resultado);

const produtos = [
  { nome: "NotBook", preco: 200, fragil: true },
  { nome: "Ipod Pro", preco: 423, fragil: true },
  { nome: "Copo de Vidro", preco: 123, fragil: true },
  { nome: "Copo de Plástico", preco: 43, fragil: false },
];

let resultadoProdutos = produtos.find((p) => {
  return p.fragil;
});

console.log("resultado produtos", resultadoProdutos);

const produtosFilter = [
  { nome: "NotBook", preco: 200, fragil: true },
  { nome: "Ipod Pro", preco: 423, fragil: true },
  { nome: "Copo de Vidro", preco: 123, fragil: true },
  { nome: "Copo de Plástico", preco: 43, fragil: false },
];

let resultadoProdutosFilter = produtosFilter.filter((p) => {
  return p.preco < 200 && !p.fragil;
});

console.log("Resultados Produto Filter", resultadoProdutosFilter);
