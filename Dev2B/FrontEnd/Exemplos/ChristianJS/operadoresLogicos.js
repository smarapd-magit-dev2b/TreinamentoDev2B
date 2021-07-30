function compras(trabalho1, trabalho2) {
  const comprarSorvete = trabalho1 || trabalho2;
  const comprarTv50 = trabalho1 && trabalho2;
  const comprarTv32 = trabalho1 != trabalho2;
  const serFit = !comprarSorvete;
  return { comprarSorvete, comprarTv50, comprarTv32, serFit };
}

console.log(compras(true, true));
console.log(compras(true, false));
console.log(compras(false, true));
console.log(compras(false, false));

let nota = 10;

const resultado = nota >= 7 ? "Aprovado" : "Reprovado";
console.log(resultado);

const resultado2 = nota >= 7 && "Aprovado";

console.log(resultado2);
