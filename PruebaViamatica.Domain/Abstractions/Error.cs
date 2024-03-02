using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaViamatica.Domain.Abstractions;

public record Error(string Code, string Name)
{
    public static Error None = new(string.Empty, String.Empty);
    public static Error NullValue = new("Error.NullValue", "Ingresó un valor nulo");
}
