using OrbitalMonitor.Interfaces;

namespace OrbitalMonitor.Models
{
    public class Satelite : EntidadeEspacial, IMonitoramento
    {
        public string TipoOrbita { get; set; }

        public override string GerarAlerta()
        {
            return $"Satélite {Nome} operando normalmente.";
        }
    }
}