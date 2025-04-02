using System;
using System.Security.Cryptography.X509Certificates;

namespace EasyFinances.Model;

public abstract class Pessoa
{
    public Guid Id { get; set; }

    public ICollection<Lancamento> Lancamentos { get; set; } 

}
