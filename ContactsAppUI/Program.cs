﻿using System;
using System.Windows.Forms;

namespace ContactsAppUI
{
    static class Program
    {
        /// <summary>
        /// Точка входа в приложение
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ContactsForm());
        }
    }
}