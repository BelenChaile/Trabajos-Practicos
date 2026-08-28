using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajos_Practicos.Practico1;
using Trabajos_Practicos.Practico2;
using Trabajos_Practicos.Practico4;

namespace Trabajos_Practicos
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormularioMenu());
        }
    }
}
