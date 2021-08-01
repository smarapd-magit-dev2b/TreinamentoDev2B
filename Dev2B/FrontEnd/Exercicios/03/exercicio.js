console.log('Exercício 1');

cumprimentar = (nome) => `Olá ${nome}!`;

console.log(cumprimentar('Maurício'));

console.log('\nExercício 2');

converterIdadeEmAnosParaDias = (idade) => idade * 365;

console.log(converterIdadeEmAnosParaDias(29));

console.log('\nExercício 3');

nomeDoMes = (mes) => {
  switch (mes) {
    case 1:
      return 'Janeiro';
    case 2:
      return 'Fevereiro';
    case 3:
      return 'Março';
    case 4:
      return 'Abril';
    case 5:
      return 'Maio';
    case 6:
      return 'Junho';
    case 7:
      return 'Julho';
    case 8:
      return 'Agosto';
    case 9:
      return 'Setembro';
    case 10:
      return 'Outubro';
    case 11:
      return 'Novembro';
    case 12:
      return 'Dezembro';
    default:
      return `${mes} é um mês inválido`;
  }
};

console.log(nomeDoMes(2));
console.log(nomeDoMes(4));

console.log('\nExercício 4 como no exemplo');

maiorOuIgual = (num1, num2) => num1 >= num2 && num1 === num2;

console.log(maiorOuIgual(8, 8));
console.log(maiorOuIgual(8, '8'));
console.log(maiorOuIgual(5, 1));

console.log('\nExercício 4 como no enunciado');

maiorOuIgual = (num1, num2) => num1 >= num2 && typeof num1 == typeof num2;

console.log(maiorOuIgual(8, 8));
console.log(maiorOuIgual(8, '8'));
console.log(maiorOuIgual(5, 1));

console.log('\nExercício 5');

inverso = (parametro) => {
  if (typeof parametro == 'boolean') return !parametro;
  else if (typeof parametro == 'number') return (parametro *= -1);
  else
    return `booleano ou numérico esperamos, mas o parâmetro é do tipo ${typeof parametro}`;
};

console.log(inverso(true));
console.log(inverso('6'));
console.log(inverso(-200));
console.log(inverso('programação'));

console.log('\nExercício 6');

estaEntre = (numero, minimo, maximo, inclusivo = false) => {
  if (inclusivo && numero >= minimo && numero <= maximo) return true;
  if (numero > minimo && numero < maximo) return true;
  return false;
};

console.log(estaEntre(51, 50, 100));
console.log(estaEntre(16, 100, 160));
console.log(estaEntre(3, 3, 150));
console.log(estaEntre(3, 3, 150, true));

console.log('\nExercício 7');

multiplicar = (num1, num2) => {
  let ehPositivo = num1 >= 0 && num2 >= 0;
  let ehInteiro = Number.isInteger(num1) && Number.isInteger(num2);

  if (ehPositivo && ehInteiro) return Math.imul(num1, num2);
};

console.log(multiplicar(5, 5));
console.log(multiplicar(0, 7));

console.log('\nExercício 8');

repetir = (elemento, quantidade) => {
  const array = [];
  for (let i = 0; i < quantidade; i++) array.push(elemento);
  return array;
};

console.log(repetir('código', 2));
console.log(repetir(7, 2));

console.log('\nExercício 8 muito louco');

repetir = (elemento, quantidade) => {
  const array = new Array(quantidade + 1).join(`${elemento};`).split(';');
  array.pop();
  return array;
};

console.log(repetir('MuitoLoko', 9));

console.log('\nExercício 9');

simboloMais = (quantidade) => '+'.repeat(quantidade);

console.log(simboloMais(2));
console.log(simboloMais(4));

console.log('\nExercício 9 muito louco');

simboloMais = (quantidade) => new Array(quantidade + 1).join('+');

console.log(simboloMais(2));
console.log(simboloMais(4));

console.log('\nExercício 10');

receberPrimeiroEUltimoElemento = (array = []) =>
  typeof array == 'object'
    ? [array[0], array[array.length - 1]]
    : `${array} não é um valor válido`;

console.log(receberPrimeiroEUltimoElemento([7, 14, 'olá']));
console.log(receberPrimeiroEUltimoElemento([-100, 'aplicativo', 16]));

console.log('\nExercício 11');

removerPropriedade = (objeto = {}, propriedade) => {
  if (typeof objeto == 'object' && typeof propriedade == 'string') {
    novoObjeto = Object.assign({}, objeto);
    delete novoObjeto[propriedade];
    return novoObjeto;
  } else if (typeof objeto != 'object' && typeof propriedade != 'string') {
    return `${objeto} e ${propriedade} são inválidos`;
  } else if (typeof objeto != 'object') {
    return `${objeto} é inválido`;
  } else if (typeof propriedade != 'string') {
    return `${propriedade} é inválido`;
}
};

console.log(removerPropriedade({ a: 1, b: 2 }, 'a'));
console.log(
  removerPropriedade(
    { id: 20, nome: 'caneta', descricao: 'Não preenchido' },
    'descricao'
  )
);

console.log('\nExercício 12');

filtrarNumeros = (array = []) => array.filter((e) => typeof e == 'number');

console.log(filtrarNumeros(['Javascript', 1, '3', 'Web', 20]));
console.log(filtrarNumeros(['a', 'c']));

console.log('\nExercício 13');

objetoParaArray = (objeto = {}) => Object.entries(objeto);

console.log(
  objetoParaArray({
    nome: 'Maria',
    profissao: 'Desenvolvedora de software',
  })
);

console.log(
  objetoParaArray({
    codigo: 11111,
    preco: 12000,
  })
);

console.log('\nExercício 14');

receberSomenteOsParesDeIndicesPares = (array = []) => {
  const novoArray = [];
  array.forEach((elemento, indice) => {
    if (indice % 2 == 0) novoArray.push(elemento);
  });
  return novoArray.filter((e) => e % 2 == 0);
};

console.log(receberSomenteOsParesDeIndicesPares([1, 2, 3, 4]));
console.log(receberSomenteOsParesDeIndicesPares([10, 70, 22, 43]));

console.log('\nExercício 15');

checarAnoBissexto = (ano) =>
  ano % 4 == 0 && (ano % 100 != 0 || ano % 400 == 0) ? true : false;

console.log(checarAnoBissexto(2020));
console.log(checarAnoBissexto(2100));

}

console.log(estaEntre(51, 50, 100))
console.log(estaEntre(16, 100, 160))
console.log(estaEntre(3, 3, 150))
console.log(estaEntre(3, 3, 150, true))

console.log('\nExercício 7')

var multiplicar = (num1, num2) => {
  let ehPositivo = num1 >= 0 && num2 >= 0
  let ehInteiro = Number.isInteger(num1) && Number.isInteger(num2)

  if (ehPositivo && ehInteiro) return Math.imul(num1, num2)
}

console.log(multiplicar(5, 5))
console.log(multiplicar(0, 7))

console.log('\nExercício 8')

var repetir = (elemento, quantidade) => {
  let array = []
  for (let i = 0; i < quantidade; i++) array.push(elemento)
  return array
}

console.log(repetir('código', 2))
console.log(repetir(7, 2))

console.log('\nExercício 8 muito louco')

var repetir = (elemento, quantidade) => {
  let array = new Array(quantidade + 1).join(`${elemento};`).split(';')
  array.pop()
  return array
}

console.log(repetir('MuitoLoko', 9))

console.log('\nExercício 9')

var simboloMais = (quantidade) => '+'.repeat(quantidade)

console.log(simboloMais(2))
console.log(simboloMais(4))

console.log('\nExercício 9 muito louco')

var simboloMais = (quantidade) => new Array(quantidade + 1).join('+')

console.log(simboloMais(2))
console.log(simboloMais(4))