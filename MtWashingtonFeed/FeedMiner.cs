using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MtWashingtonFeed
{
    static class FeedMiner
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }

        /// <summary>
        /// Registry
        /// </summary>
        static RegHdlr Registry = new RegHdlr(@"HairyLogic/FeedMiner");

        /// <summary>
        /// FirstRun
        /// </summary>
        public static bool FirstRun
        {
            get 
            {
                return bool.TrueString.Equals(Registry.SoftwareKey.GetValue("FirstRun", bool.TrueString));
            }
            set
            {
                Registry.SoftwareKey.SetValue("FirstRun", value);
            }
        }
    }
}
