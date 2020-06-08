using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatarzynaKrawczykLab2ZadDom
{
    interface IBasicFightAction
    {
        double Hit();
        bool GetHit(double damage);
    }
}
