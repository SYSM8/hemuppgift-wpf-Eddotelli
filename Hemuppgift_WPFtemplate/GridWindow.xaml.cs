using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Hemuppgift_WPFtemplate
{
    /// <summary>
    /// Interaction logic for GridWindow.xaml
    /// </summary>
    public partial class GridWindow : Window
    {
        public GridWindow()
        {
            InitializeComponent();
        }

        //Metod för Apply-knappen.
        private void btnApply_Click(object sender, RoutedEventArgs e)
        {
            //Konvertar string-inmatningen till int.
            int row = Convert.ToInt32(txtRow.Text);
            int column = Convert.ToInt32(txtColumn.Text);

            //Om inmattningen är större eller lika med noll.
            if(row >= 0 && column >= 0)
            {
                //För att förflytta rectangeln.
                Grid.SetRow(recRec,row);
                Grid.SetColumn(recRec, column);


                //För att förflytta texten som visar rad och kolumn.
                Grid.SetRow(Result, row);
                Grid.SetColumn(Result, column);

                Result.Text = $"Row: {Convert.ToString(row)}, Column: {Convert.ToString(column)}";

            }        
        }
    }
}
