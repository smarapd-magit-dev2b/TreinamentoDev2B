const imprimir = function (nota) {
  switch (Math.floor(nota)) {
    case 10:
    case 9:
      console.log("Quador de Honra");
      break;
    case 8:
    case 7:
      console.log("Aprovado");
      break;
    case 6:
    case 5:
      console.log("Recuperação");
      break;
    case 4:
    case 3:
    case 2:
    case 1:
    case 0:
      console.log("Reprovado");
    default:
      console.log("Nota inválida");
  }
};

imprimir("t");
imprimir(5.5);
