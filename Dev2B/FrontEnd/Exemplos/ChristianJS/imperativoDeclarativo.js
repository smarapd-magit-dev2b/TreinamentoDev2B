const alunos = [
  { nome: "João", nota: 7.9 },
  { nome: "Maria", nota: 9.9 },
  { nome: "Roberto", nota: 3.2 },
];

let total1 = 0;
for (let i = 0; i < alunos.length; i++) {
  total1 += alunos[i].nota;
}

console.log(total1 / alunos.length);

const getNota = (aluno) => aluno.nota;
const soma = (total, atual) => total + atual;
const media = (somaNota, qtdAluno) => somaNota / qtdAluno;

const total2 = alunos.map(getNota).reduce(soma);
console.log(media(total2, alunos.length));
