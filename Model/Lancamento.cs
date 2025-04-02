using System.ComponentModel.DataAnnotations;
using EasyFinances.Model;

namespace EasyFinances;

public abstract class Lancamento
{
    public Guid Id { get; set; }
    public DateTime Data { get; set;}
    public decimal Valor { get; set;}

    //Mapeamentos
    public Guid ContaBancariaId { get ;set;}
    public ContaBancaria ContaBancaria { get; set; }

    public Categoria Categoria { get; set; }
    public Guid CategoriaId { get; set; }

    public Pessoa Pessoa { get; set; }
    public Guid PessoaId { get; set; }


}
