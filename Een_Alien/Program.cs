using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace Een_Alien
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
            // To start a game you need to start the gameloop.
            //Gameloop loop = new Gameloop();
            //loop.Elapsed += testshit;
            //loop.Start();
            View.Mainmenu menu = new View.Mainmenu();
            Application.Run(menu);
        }

        //private static void testshit(Object source, ElapsedEventArgs e)
        //{
        //    Console.WriteLine("Tick : " + e.SignalTime);
        //}/
    }
}
