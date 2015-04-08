using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Windows.Forms;



using JamesConcentrate.Data;
using JamesConcentrate.Game;
using JamesConcentrate.Controller;

namespace JamesConcentrateApplication
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MainForm mainForm = new MainForm();
            mainForm.Visible = false;

            IList gameData = new ArrayList();

            JamesDataController controller = new JamesDataController(mainForm, gameData);
            mainForm.ShowDialog();

        }
    }
}
