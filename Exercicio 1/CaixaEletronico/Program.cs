// See https://aka.ms/new-console-template for more information
using CaixaEletronico.Domain;
using CaixaEletronico.Interface;
using CaixaEletronico.Service;
using System.Drawing;

Console.WriteLine("------------- CAIXA ELETRÔNICO -------------");

var notas100 = new Nota100(5);
var notas50 = new Nota50(10);
var notas20 = new Nota20(20);
var notas10 = new Nota10(35);
var opcao = 1;

var saqueService = new TransacaoService(new List<INota> { notas100, notas50, notas20, notas10 });

while (opcao == 1)
{


    Console.Write(" Informe o valor do saque: ");
    var valorSolicitado = Console.ReadLine();
    var valor = 0;

    if (int.TryParse(valorSolicitado, out valor) && valor > -1)
    {
        var notasRetornadas = saqueService.Sacar(valor);

        foreach (var nota in notasRetornadas)
        {
            string mensagem = string.Format("Nota(s) de {0}: {1}", nota.Key, nota.Value);
            Console.WriteLine(mensagem);
        }
    }

    Console.WriteLine();

    Console.WriteLine("(1) - Para realizar novo saque");
    Console.WriteLine("(2) - Para sair do programa");

    opcao = Convert.ToInt32(Console.ReadLine());
}