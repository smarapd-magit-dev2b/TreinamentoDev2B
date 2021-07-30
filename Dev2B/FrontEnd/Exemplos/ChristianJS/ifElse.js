const imprimirResultado = function (nota) {
  if (nota >= 7) console.log("Aprovado!");
  else if (nota >= 5) console.log("Recuperação");
  else if (nota > 0 && nota < 5) console.log("Reprovado");
  else console.log("Valor inválido");
};

imprimirResultado(10);
imprimirResultado(6);
imprimirResultado(3);
imprimirResultado("teste");
