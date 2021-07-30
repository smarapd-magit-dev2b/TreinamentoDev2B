function imprimirSoma(a, b) {
  console.log(a + b);
}

imprimirSoma(2, 3);
imprimirSoma(2);

function soma(a, b = 1) {
  return a + b;
}

console.log(soma(3));
console.log(soma(3, 2));

const funcImprimirSoma = function (a, b) {
  console.log(a + b);
};

const arrowSoma = (a, b) => a + b;

console.log(arrowSoma(2, 5));
