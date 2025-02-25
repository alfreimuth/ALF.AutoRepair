using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALF.AutoRepair.BL
{
    internal interface IStartable
    {
        bool IsRunning { get; set; }
        void Start();
    }
}
