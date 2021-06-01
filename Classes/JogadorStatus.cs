namespace statusJogador.Classes
{
    public class JogadorStatus
    {
        public string Nome {get; set;}
        public int Pontos {get; set;}
        public int Assistencias {get; set;}
        public int Rebotes {get; set;}

        public JogadorStatus(string nome, int pontos, int assistencias, int rebotes){
            this.Nome = nome;
            this.Pontos = pontos;
            this.Assistencias = assistencias;
            this.Rebotes = rebotes;
        }
    }
}