using CaixaEletronico.Interface;

namespace CaixaEletronico.Domain
{
    internal class Nota50 : NotaBase, INota
    {
        public override int ValorNota { get => 50; }
        public Nota50(int qtdeCedulas) : base(qtdeCedulas)
        {
        }
    }
}
