using System;
using System.Collections.Generic;

namespace ETITC.Models;

public partial class Role
{
    public int IdRol { get; set; }

    public string NombreRol { get; set; } = null!;

    public string Estado { get; set; } = null!;
}
