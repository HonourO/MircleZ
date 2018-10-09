using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MyDev.Demo {
    static class Program {
        public static bool isValidUser;
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main() {
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.Skins.SkinManager.EnableMdiFormSkins();
            //text git
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ParentForm());
        //               if (isValidUser == true)
         //                 Application.Run(new ParentForm());

            }
        }
    }


