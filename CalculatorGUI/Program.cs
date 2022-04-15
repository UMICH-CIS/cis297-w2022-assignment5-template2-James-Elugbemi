//Program: GUI Calculator with Forms
//Description: A GUI implementation of my first C# assignment
//Programmer: James Elugbemi
//Date: 4/14/2022

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CalculatorGUI
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
         Application.SetCompatibleTextRenderingDefault( false );
         Application.Run( new CalculatorGUIForm() );
      }
   }
}
