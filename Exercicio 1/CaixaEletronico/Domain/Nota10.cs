using CaixaEletronico.Interface;

namespace CaixaEletronico.Domain
{
    internal class Nota10 : NotaBase, INota
    {
        public override int ValorNota { get => 10; }
        public Nota10(int qtdeCedulas) : base(qtdeCedulas)
        {
        }


    }
}
