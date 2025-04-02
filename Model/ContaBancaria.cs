namespace EasyFinances;

public class ContaBancaria
{
    //Atributos
    public int Id { get; set; }
    public string NomeInstituicao { get; set; }
    public string Agencia { get; set; }
    public string Conta { get; set; }

    //Mapeamentos
    public Guid TitularId { get; set; }
    public Usuario Usuario { get; set; }
}
