using CaixaEletronico.Interface;

namespace CaixaEletronico.Domain
{
    public abstract class NotaBase : INota
    {
        public NotaBase(int qtdeCedulas)
        {
            QtdeCedulas = qtdeCedulas;
        }

        public int QtdeCedulas { get; set; }
        public abstract int ValorNota { get; }

        public int CalculaQuantidadeNotas(ref int valorSolicitado)
        {
            var notas = 0;
            notas = QtdeCedulas - (valorSolicitado / ValorNota) <= 0 ? 0 : (valorSolicitado / ValorNota);

            if (notas > 0)
                valorSolicitado -= (ValorNota * notas);

            return notas;
        }

        public string GetValorNota()
        {
            return ValorNota.ToString();
        }
    }
}
