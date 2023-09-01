using System;
using System.Collections.Generic;

namespace ETITC.Models;

public partial class Producto
{
    public int IdProducto { get; set; }

    public int IdCategoria { get; set; }

    public int IdProveedor { get; set; }

    public string NombreProducto { get; set; } = null!;

    public double PrecioCompra { get; set; }

    public double PrecioVenta { get; set; }

    public double? DescuentoProducto { get; set; }

    public int Stock { get; set; }

    public string DescripcionProducto { get; set; } = null!;
}
