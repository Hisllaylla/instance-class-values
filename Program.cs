var cliente1 = new Cliente // instancia
{
    Id = 1,
    Nome = "chaveprimaria",
    Documento = "98765432101",
    EstadoCivil = "Solteira",
    Profissao = "Estudante"
};

Console.WriteLine($"{cliente1}"); // print

var cliente2 = new Cliente // instancia
{
    Id = 2,
    Nome = "hisllaylla",
    Documento = "1234567890x",
    EstadoCivil = "Casada",
    Profissao = "Estagiária"
};

Console.WriteLine($"{cliente2}"); // print

var cliente3 = new Cliente // instância
{
    Id = 3,
    Nome = cliente1.Nome, // valor atribuido de outro objeto
    Documento = "74387278429",
    EstadoCivil = cliente2.EstadoCivil, // valor atribuido de outro objeto
    Profissao = "Programadora",
};

Console.WriteLine($"{cliente3}"); // print