using OrbitalMonitor.Interfaces;

namespace OrbitalMonitor.Models
{
    public class Sensor : EntidadeEspacial, IMonitoramento
    {
        public double Temperatura { get; set; }

        public override string GerarAlerta()
        {
            return $"Sensor {Nome} registrando temperatura de {Temperatura}°C";
        }
    }
}