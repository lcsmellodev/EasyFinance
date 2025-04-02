using System;

namespace EasyFinances.Model;

public class SubCategoria
{
    public Guid Id { get; set; }
    public string Nome { get; set; }
    

    //Mapeamentos
    public Guid CategoriaId { get; set; }
    public Categoria Categoria { get; set; }
}
