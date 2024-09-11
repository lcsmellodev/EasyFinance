using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace EasyFinances;

public class Titular
{
    
    [MaxLength(14)]
    public string CPF { get; set; }
    public ContaBancaria ContaBancaria{ get; set; }
    private string _primeiroNome { get;  set; }
    private string _sobrenome{ get; set;}

    public string Nome 
        {
            get{ return $"{_primeiroNome} {_sobrenome}";}
        }

    //Mapeamentos
   
   public ICollection<ContaBancaria> ContasBancarias { get; set; }
    
    
    


}

