namespace plataformaJogos
{
    public abstract class Jogo
    {
        public string nome { get; set; }
        
        public string idJogo { get; set; }

        public string online { get; set; }

        public string dataLancamento { get; set; }

        public string resumoJogo { get; set; }

        public string personagensPrincipal { get; set; }

        public string lojaDisponivel { get; set; }

    }

}