namespace InstanceClassValues;

public class Cliente
{
    public int? Id { get; set; } // interrogação é o recuros do C3 que atri
    public string? Nome { get; set; }
    public string? Documento { get; set; }
    public string? EstadoCivil { get; set; }
    public string? Profissao { get; set; }

    public override string ToString()
    {
        return $"ID: {Id}, Nome: {Nome}, Documento: {Documento}, Estado Civil: {EstadoCivil}, Profissão: {Profissao}";
    }
}