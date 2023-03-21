namespace CaixaEletronico.Interface
{
    public interface INota
    {
        public int CalculaQuantidadeNotas(ref int valorSolicitado);
        string GetValorNota();
    }
}
