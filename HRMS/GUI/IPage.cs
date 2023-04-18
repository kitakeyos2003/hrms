using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.GUI
{
    internal interface IPage
    {
        void InitPage();
        void NextPage();
        void PreviousPage();
    }
}
