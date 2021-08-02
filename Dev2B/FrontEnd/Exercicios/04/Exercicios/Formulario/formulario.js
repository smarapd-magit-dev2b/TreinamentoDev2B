$('.formulario').on('submit', 'form[name="cadastro"]', function (evento) {
  event.preventDefault();

  let nome = $('input[name="nome"]').val();
  let especialidade = $('input[name="especialidade"]:checked').val();
  let linguagem = $('select[name="linguagem"]').val();

  $('#lista').append(`<tr>
                        <td>${nome}</td>
                        <td>${especialidade}</td>
                        <td>${linguagem}</td>
                        <td class="acoes">
                          <button>Editar</button>
                          <button>Deletar</button>
                        </td>
                      </tr>`);
});

$('.formulario').on('submit', 'form[name="atualizacao"]', function (evento) {
  event.preventDefault();

  let nome = $('input[name="nome"]').val();
  let especialidade = $('input[name="especialidade"]:checked').val();
  let linguagem = $('select[name="linguagem"]').val();

  console.log(nome);

  let linha = $('tr#atualizando').children('[class!=acoes]');

  console.log(linha);

  linha.eq(0).text(nome);
  linha.eq(1).text(especialidade);
  linha.eq(2).text(linguagem);

  $('tr.atualizando').removeClass();
  $('form[name="atualizacao"]').removeAttr('name').attr('name', 'cadastro');
});

$('#lista').on('click', 'button', function (evento) {
  event.preventDefault();
  let botao = $(event.target);

  if (botao.text() == 'Deletar') botao.parent().parent().remove();
  else if (botao.text() == 'Editar') {
    botao.parent().parent().prop('id', 'atualizando');
    let tds = botao.parent().parent().children('[class!=acoes]');

    let nome = tds.eq(0).text();
    let especialidade = tds.eq(1).text();
    let linguagem = tds.eq(2).text();

    $('input[name="nome"]').val(nome);
    $(`input[name="especialidade"][value="${especialidade}"]`).prop(
      'checked',
      true
    );
    $('select[name="linguagem"]').val(linguagem);

    $('form[name="cadastro"]').removeAttr('name').attr('name', 'atualizacao');
  }
});
