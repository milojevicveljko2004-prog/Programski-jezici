using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad4
{
    public interface INaplata
    {
        string Valuta { get; }
        double Cena { get; }
        double Limit { get; } //najveca dozvoljena cena za isplatu
    }
}
