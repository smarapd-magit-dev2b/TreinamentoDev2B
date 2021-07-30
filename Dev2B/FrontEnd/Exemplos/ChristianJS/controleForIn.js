const notas = [5.2, 7.4, 9.9, 7.7];

for (const i in notas) {
  console.log(i, notas[i]);
}

const pessoa = {
  nome: "Ana",
  sobrenome: "Silva",
  idade: 29,
  peso: 64,
};

for (let atributo in pessoa) {
  console.log(`${atributo} = ${pessoa[atributo]}`);
}

for (let item of notas) {
  console.log(item);
}
