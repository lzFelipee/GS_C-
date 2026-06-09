using OrbitalMonitor.Exceptions;
using OrbitalMonitor.Models;
using OrbitalMonitor.Services;
using OrbitalMonitor.Structs;

Utilitario.ExibirTitulo();

Satelite satelite = new Satelite
{
    Nome = "FIAP-SAT-01",
    TipoOrbita = "Órbita Baixa",
    DataCadastro = DateTime.Now
};

Sensor sensor = new Sensor
{
    Nome = "Sensor Térmico",
    Temperatura = 65,
    DataCadastro = DateTime.Now
};

Coordenada coordenada = new Coordenada(-23.5505, -46.6333);

Console.WriteLine(satelite.GerarAlerta());
Console.WriteLine(sensor.GerarAlerta());

Console.WriteLine();
Console.WriteLine($"Latitude: {coordenada.Latitude}");
Console.WriteLine($"Longitude: {coordenada.Longitude}");

MonitoramentoService service = new MonitoramentoService();

try
{
    service.ValidarTemperatura(sensor);

    Console.WriteLine();
    Console.WriteLine("Temperatura dentro do limite.");
}
catch (MonitoramentoException ex)
{
    Console.WriteLine();
    Console.WriteLine(ex.Message);
}

Console.WriteLine();
Console.WriteLine($"Data do registro: {DateTime.Now}");