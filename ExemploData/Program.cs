using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExemploData.Controllers.Helps;
using ExemploData.View;

namespace ExemploData
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread] 
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            new ClientesContextDataInitial(new ClientesContext()).Seed();

            //Task.Run(async () =>
            //{
            //    using (var r = new Form2())
            //    {
            //        r.Show();
            //        await new ClientesContextDataInitial(new ClientesContext()).Seed();
            //    }
            //}).Wait();
            Application.Run(new Form1());
        }
    }
}
