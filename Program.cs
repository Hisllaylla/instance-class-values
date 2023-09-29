var cliente1 = new Cliente
{
    Id = 1,
    Nome = "chaveprimaria",
    Documento = "98765432101",
    EstadoCivil = "Solteira",
    Profissao = "Estudante"
};

Console.WriteLine($"{cliente1}");

var cliente2 = new Cliente
{
    Id = 2,
    Nome = "hisllaylla",
    Documento = "1234567890x",
    EstadoCivil = "Casada",
    Profissao = "Estagiária"
};

Console.WriteLine($"{cliente2}");

var cliente3 = new Cliente
{
    Id = 3,
    Nome = cliente1.Nome,
    Documento = "74387278429",
    EstadoCivil = cliente2.EstadoCivil,
    Profissao = "Programadora",
};

Console.WriteLine($"{cliente3}");