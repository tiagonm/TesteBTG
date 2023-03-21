using CaixaEletronico.Interface;
using System.Reflection.Metadata.Ecma335;

namespace CaixaEletronico.Domain
{
    public class Nota100 : NotaBase, INota
    {
        public override int ValorNota { get => 100; }
        public Nota100(int qtdeCedulas) : base(qtdeCedulas)
        {
        }
    }
}
