namespace OrbitalMonitor.Models
{
    public abstract class EntidadeEspacial
    {
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public DateTime DataCadastro { get; set; }

        public abstract string GerarAlerta();
    }
}