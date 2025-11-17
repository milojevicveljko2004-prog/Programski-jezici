using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1Project
{

    public enum SortOrder { Rastuci, Opadajuci }

    public enum StanjeKolekcije { Neuredjena, UredjenaURastuci, UredjenaUOpadajuci }
    public interface Uredjivac
    {
        //uredjuje u rastuci ili opadajuci redosled
        void Uredi(SortOrder redosled);
    }
}
