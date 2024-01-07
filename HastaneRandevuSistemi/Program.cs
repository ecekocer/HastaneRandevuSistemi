using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneRandevuSistemi
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    class Program
    {

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new HastaneSistemiForm());
        }
    }
}
