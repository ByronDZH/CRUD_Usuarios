using System;
using System.Collections.Generic;

namespace Ejercicio1.Models;

public partial class Usuario
{
    public int Idusuarios { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string Coreo { get; set; } = null!;

    public string Password { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }
}
