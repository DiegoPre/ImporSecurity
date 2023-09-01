using System;
using System.Collections.Generic;

namespace ETITC.Models;

public partial class Factura
{
    public int IdFactura { get; set; }

    public DateTime FechaFactura { get; set; }

    public int IdOrden { get; set; }

    public double VrImpuestos { get; set; }

    public double VrVentaFactura { get; set; }

    public double? VrFlete { get; set; }

    public double VrTotalPago { get; set; }

    public int IdMetodoPago { get; set; }
}
