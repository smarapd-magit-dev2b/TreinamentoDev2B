console.log('Exercício 1')

var cumprimentar = (nome) => `Olá ${nome}!`

console.log(cumprimentar('Maurício'))

console.log('\nExercício 2')

var converterIdadeEmAnosParaDias = (idade) => idade * 365

console.log(converterIdadeEmAnosParaDias(29))

console.log('\nExercício 3')

var nomeDoMes = (mes) => {
  switch (mes) {
    case 1:
      return 'Janeiro'
    case 2:
      return 'Fevereiro'
    case 3:
      return 'Março'
    case 4:
      return 'Abril'
    case 5:
      return 'Maio'
    case 6:
      return 'Junho'
    case 7:
      return 'Julho'
    case 8:
      return 'Agosto'
    case 9:
      return 'Setembro'
    case 10:
      return 'Outubro'
    case 11:
      return 'Novembro'
    case 12:
      return 'Dezembro'
    default:
      return `${mes} é um mês inválido`
  }
}

console.log(nomeDoMes(2))
console.log(nomeDoMes(4))

console.log('\nExercício 4 como no exemplo')

var maiorOuIgual = (num1, num2) => num1 >= num2 && num1 === num2

console.log(maiorOuIgual(8, 8))
console.log(maiorOuIgual(8, '8'))
console.log(maiorOuIgual(5, 1))

console.log('\nExercício 4 como no enunciado')

var maiorOuIgual = (num1, num2) => num1 >= num2 && typeof num1 == typeof num2

console.log(maiorOuIgual(8, 8))
console.log(maiorOuIgual(8, '8'))
console.log(maiorOuIgual(5, 1))
