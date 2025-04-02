using System.Diagnostics.Eventing.Reader;

namespace EasyFinances;

public class Categoria
{
    public Guid Id { get; set; }
    public string Nome { get; set; }

    public bool Fixo {get; set; }
    public bool Essencial{get; set; }

    public Lancamento Lancamento { get; set; }
    public Guid LancamentoId { get; set; }

}
