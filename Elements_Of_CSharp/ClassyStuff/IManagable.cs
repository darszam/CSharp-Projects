using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassyStuff
{
    interface IManagable
    {
        void Hire(AbstractEmployee e);
        void Fire(AbstractEmployee e);
        void Raise(AbstractEmployee e, AbstractEmployee higher);

    }
}
