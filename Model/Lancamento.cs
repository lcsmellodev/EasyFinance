using System.ComponentModel.DataAnnotations;

namespace EasyFinances;

public class Lancamento
{
    public Guid Id { get; set; }
    public DateTime Data { get; set;}
    public decimal Valor { get; set;}

    //Mapeamentos
    public Guid ContaBancariaId { get ;set;}
    public ContaBancaria ContaBancaria { get; set; }


}
