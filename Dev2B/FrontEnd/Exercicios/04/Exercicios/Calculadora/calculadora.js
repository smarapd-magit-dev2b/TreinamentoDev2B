const sentenca = function () {
  if ($(this).text() == 'C') {
    $('#sentenca').empty();
    $('#resultado').empty();
  } else $('#sentenca').append($(this).text());
};

$('button.numerico').click(sentenca);

$('button.operacao').click(sentenca);

$('button.igualdade').click(function () {
  $('#resultado').text(calcular($('#sentenca').text()));
});

const operadores = ['x', '÷', '-', '+'];

const separar = (calculo = '') => {
  for (const operador of operadores)
    calculo = calculo.replace(
      new RegExp(`\\${operador}`, 'g'),
      `;${operador};`
    );

  calculo.trim();

  while (calculo.includes(';;')) calculo.replace(';;', ';');

  return calculo.split(';');
};

const numerar = (calculoSeparado = ['']) => {
  const calculoNumerado = [];

  for (const argumento of calculoSeparado) {
    let numero = Number.parseFloat(argumento);

    if (numero) calculoNumerado.push(numero);
    else calculoNumerado.push(argumento);
  }

  return calculoNumerado;
};

const calcular = (calculo = '') => {
  const calculoSeparado = separar(calculo);
  const calculoNumerado = numerar(calculoSeparado);

  const calculadora = {
    '+': (numerador, numerando) => numerador + numerando,
    '-': (numerador, numerando) => numerador - numerando,
    x: (numerador, numerando) => numerador * numerando,
    '÷': (numerador, numerando) => numerador / numerando,
  };

  for (const operador of operadores) {
    while (calculoNumerado.includes(operador)) {
      let indiceOperador = calculoNumerado.indexOf(operador);
      let numerador = calculoNumerado[indiceOperador - 1];
      calculoNumerado[indiceOperador - 1] = calculadora[operador](
        numerador,
        calculoNumerado[indiceOperador + 1]
      );
      calculoNumerado.splice(indiceOperador, 2);
    }
  }

  return calculoNumerado[0];
};
