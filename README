# Orbital Monitor

## Descrição do Projeto

O Orbital Monitor é uma aplicação desenvolvida em C# com o objetivo de simular o monitoramento de satélites e sensores espaciais. O sistema registra informações de satélites, coleta dados de sensores, realiza validações de temperatura e gera alertas para auxiliar no acompanhamento das condições operacionais dos equipamentos espaciais.

O projeto foi desenvolvido para aplicar conceitos de Programação Orientada a Objetos (POO), abstração, interfaces, tratamento de exceções, estruturas auxiliares e organização de código utilizando a plataforma .NET.

---

## Integrantes

- Luiz Felipe Motta da Silva – RM 559126
- Pedro Henrique Faim dos Santos – RM 557440
- Nicolas Lorenzo Ferreira da Silva – RM 557962

---

## Tecnologias Utilizadas

### C#
Linguagem principal utilizada para o desenvolvimento da aplicação.

### .NET
Framework utilizado para criação e execução da aplicação Console.

### Programação Orientada a Objetos (POO)
Aplicação dos conceitos de:
- Encapsulamento
- Herança
- Polimorfismo
- Abstração

### Interfaces
Utilizadas para promover desacoplamento e melhor organização do código.

### Tratamento de Exceções
Utilização de exceções personalizadas para validar situações críticas durante o monitoramento.

### Structs
Utilização da estrutura `Coordenada` para armazenamento de latitude e longitude.

### DateTime
Utilizado para registrar a data e hora de cadastro dos objetos monitorados.

---

## Estrutura do Projeto

```text
OrbitalMonitor
│
├── Models
│   ├── EntidadeEspacial.cs
│   ├── Satelite.cs
│   └── Sensor.cs
│
├── Interfaces
│   └── IMonitoramento.cs
│
├── Services
│   ├── MonitoramentoService.cs
│   └── Utilitario.cs
│
├── Exceptions
│   └── MonitoramentoException.cs
│
├── Structs
│   └── Coordenada.cs
│
└── Program.cs
```

---

## Conceitos Aplicados

### Modelagem de Domínio e POO

O sistema foi modelado utilizando entidades relacionadas ao contexto espacial:

- Satélite
- Sensor
- Coordenadas

Também foram aplicados:

- Classes públicas e privadas
- Herança
- Polimorfismo
- Encapsulamento

### Abstração

A classe `EntidadeEspacial` foi implementada como uma classe abstrata, servindo de base para as demais entidades do sistema.

### Interfaces

A interface `IMonitoramento` define contratos para funcionalidades relacionadas ao monitoramento.

### Estruturas de Controle e Métodos

O sistema utiliza métodos específicos para geração de alertas e validação de temperatura, além de estruturas condicionais para tomada de decisão.

### Tratamento de Exceções

Foi criada a exceção personalizada `MonitoramentoException`, utilizada para identificar situações críticas de temperatura.

### Struct

A estrutura `Coordenada` foi utilizada para armazenar informações geográficas de latitude e longitude.

---

## Fluxo de Funcionamento

1. Criação do satélite.
2. Criação do sensor.
3. Registro das coordenadas.
4. Geração de alertas.
5. Validação da temperatura.
6. Tratamento de possíveis exceções.
7. Exibição do resultado ao usuário.

---

## Como Executar

### Pré-requisitos

- .NET SDK instalado

### Executar pelo terminal

```bash
dotnet run
```

### Executar pelo Visual Studio

1. Abrir a solução do projeto.
2. Compilar a aplicação.
3. Executar utilizando Ctrl + F5.

---

## Exemplo de Saída

```text
=== ORBITAL MONITOR ===

Satélite FIAP-SAT-01 operando normalmente.
Sensor Sensor Térmico registrando temperatura de 65°C

Latitude: -23,5505
Longitude: -46,6333

Temperatura dentro do limite.

Data do registro: 08/06/2026 18:25:43
```

---

## Evidências

As evidências de execução, diagrama de fluxo e capturas de tela do sistema estão disponíveis na pasta:

```text
docs/
```

---
