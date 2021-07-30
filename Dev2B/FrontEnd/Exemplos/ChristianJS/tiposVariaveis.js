let number = 1
console.log(typeof number, number)

let texto = 'texto aleatório'
console.log(typeof texto, texto)

let isActive = true;
console.log(typeof isActive, isActive)

if(!!number){
    console.log(!!number, number)
}

let nomes =['romeu', 'carioca']

console.log(nomes);
console.log(nomes[0])

let produtos = {
    televisao: 'polegadas',
    radio: 'xpto'
}

produtos.computador = 'Ryzen 5 3600...'

console.log(produtos)
console.log(produtos.televisao)

let json = {
    propriedade1: 'valor1',
    propriedade2: 'valor2',
    propriedade3: {
        subPropriedade1: 'subValor1'
    }
}

let usuarioNumero1 = null;

let usuarioNumero2

console.log(usuarioNumero1, usuarioNumero2)