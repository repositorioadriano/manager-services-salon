$(document).ready(function(){
    setTimeout(function(){$('#message-alert').fadeOut();}, 5000);
    $(".button-collapse").sideNav();
    $("#Cpf").mask("999.999.999-99");
    $("#Rg").mask("9999999999999");
    $("#DataNascimento").mask("99/99/9999");
    $("#Telefone").mask("(99) 9999-9999");
    $("#Celular").mask("(99) 9 9999-9999");
    $("#Cep").mask("99999-999");
  });
