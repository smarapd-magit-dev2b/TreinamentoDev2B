function tratarErrorE_Lancar(erro) {
  // throw new Error("Novo erro criado");
  // throw 10;
  // throw 'Mensagem de Erro'
  throw {
    nome: error.name,
    msg: error.msg,
    data: new Date(),
  };
}

function imprimirNome(obj) {
  try {
    console.log(obj.name.toUpperCase() + "!!!");
  } catch (e) {
    tratarErrorE_Lancar(e);
  } finally {
    console.log("final");
  }
}

const obj = { nome: "Cristian" };

imprimirNome(obj);
