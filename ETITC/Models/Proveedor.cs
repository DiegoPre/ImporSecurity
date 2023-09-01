using System;
using System.Collections.Generic;

namespace ETITC.Models;

public partial class Proveedor
{
    public int IdProveedor { get; set; }

    public string NombreProveedor { get; set; } = null!;

    public string DireccionProveedor { get; set; } = null!;

    public string CiudadProveedor { get; set; } = null!;

    public string PaisProveedor { get; set; } = null!;

    public string TelefonoProveedor { get; set; } = null!;

    public string EmailProveedor { get; set; } = null!;

    public string? WebProveedor { get; set; }
}
