using System;
using System.Collections.Generic;

namespace ETITC.Models;

public partial class OrdenCompra
{
    public int IdOrden { get; set; }

    public DateTime FechaOrden { get; set; }

    public int IdProducto { get; set; }

    public int CantidadItem { get; set; }

    public double VrTotal { get; set; }

    public int IdUsuario { get; set; }
}
