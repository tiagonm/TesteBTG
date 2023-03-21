using CaixaEletronico.Interface;

namespace CaixaEletronico.Service
{
    public class TransacaoService
    {
        private readonly IList<INota> _notas;
        public TransacaoService(IList<INota> notas)
        {
            _notas = notas;
        }

        public Dictionary<string, int> Sacar(int valorSolicitado)
        {
            var retorno = new Dictionary<string, int>();
            foreach (var nota in _notas)
            {
                var qtde = nota.CalculaQuantidadeNotas(ref valorSolicitado);

                if (qtde > 0)
                {
                    retorno.Add(nota.GetValorNota(), qtde);
                }
            }

            return retorno;
        }
    }
}
