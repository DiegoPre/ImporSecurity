using System;
using System.Collections.Generic;

namespace ETITC.Models;

public partial class CategoriaProducto
{
    public int IdCategoria { get; set; }

    public string NombreCategoria { get; set; } = null!;

    public string DescripcionCategoria { get; set; } = null!;

    public double ValorIvaProducto { get; set; }
}
