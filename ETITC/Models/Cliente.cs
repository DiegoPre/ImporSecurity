using System;
using System.Collections.Generic;

namespace ETITC.Models;

public partial class Cliente
{
    public int IdUsuario { get; set; }

    public int IdRol { get; set; }

    public string TipoDoc { get; set; } = null!;

    public string NoDoc { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public string Ciudad { get; set; } = null!;

    public string Pais { get; set; } = null!;

    public string Telefono { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;
}
