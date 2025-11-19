using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PjSajtKlk2016
{
    public interface INaplata
    {
        string Valuta { get; }
        double CenaZaNaplatu { get; }
        double Limit { get; } //najveca dozvoljena cena za naplatu
    }
}
