using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceFromHell
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            int exit = 0;
            int ranNum;
            Random rgen = new Random();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            do{
            Application.Run(new Form1());
            Application.Run(new Form2());
            Application.Run(new Form3());
            Application.Run(new Form4MainPage());
            ranNum = rgen.Next(1, 4);

            switch (ranNum)
            {
                case 1:
                    {
                        Application.Run(new Form5());
                        Application.Run(new Form6());
                        break;
                    }
                case 2:
                    {
                        Application.Run(new Form8());
                        break;
                    }
                case 3:
                    {
                        Application.Run(new Form9());
                        break;
                    }

            }
            Application.Run(new Form7());
        }while(exit == 0);
        }
    }
}
