using OrbitalMonitor.Exceptions;
using OrbitalMonitor.Models;

namespace OrbitalMonitor.Services
{
    public class MonitoramentoService
    {
        public void ValidarTemperatura(Sensor sensor)
        {
            if (sensor.Temperatura > 80)
            {
                throw new MonitoramentoException(
                    "Temperatura crítica detectada!"
                );
            }
        }
    }
}