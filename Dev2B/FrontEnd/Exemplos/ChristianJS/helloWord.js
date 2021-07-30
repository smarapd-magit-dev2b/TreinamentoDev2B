var variavelTipoVar = 'Hello';
let variavelTipoLet = 'Word';
const variavelTipoConst = '!';

let helloWord = `${variavelTipoVar} ${variavelTipoLet}${variavelTipoConst}`;

console.log(variavelTipoVar, variavelTipoLet, variavelTipoConst);
console.log(`Meu primeiro ${variavelTipoVar} ${variavelTipoLet}${variavelTipoConst}`);
console.log(helloWord);

let somaStringNum = Number('1') + 2;

console.log(typeof somaStringNum);