using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace EasyFinances;

public class Usuario
{
    
    [MaxLength(14)]
    public string CPF { get; set; }
    private string _primeiroNome { get;  set; }
    private string _sobrenome{ get; set;}

    public string Nome 
        {
            get{ return $"{_primeiroNome} {_sobrenome}";}
        }

    //Mapeamentos
   
    public ContaBancaria ContaBancaria{ get; set; }
   public ICollection<ContaBancaria> ContasBancarias { get; set; }
    
    
    


}

