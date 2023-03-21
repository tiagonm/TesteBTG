using CaixaEletronico.Interface;

namespace CaixaEletronico.Domain
{
    internal class Nota20 : NotaBase, INota
    {
        public override int ValorNota { get => 20; }
        public Nota20(int qtdeCedulas) : base(qtdeCedulas)
        {
        }
    }
}
