﻿using System.Windows.Controls;

namespace VMS.Client.View.Component.Map.CustomMarkers
{
   /// <summary>
   /// Interaction logic for Test.xaml
   /// </summary>
   public partial class Test : UserControl
   {
      public Test(string txt)
      {
         InitializeComponent();

         text.Text = txt;
      }
   }
}
