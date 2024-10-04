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

        private void btnApply_Click(object sender, RoutedEventArgs e)
        {
            int row = Convert.ToInt32(txtRow.Text);
            int column = Convert.ToInt32(txtColumn.Text);

            if(row >= 0 && column >= 0)
            {
                Grid.SetRow(recRec,row);
                Grid.SetColumn(recRec, column);


                Grid.SetRow(Result, row);
                Grid.SetColumn(Result, column);

                Result.Text = $"Row: {Convert.ToString(row)}, Column: {Convert.ToString(column)}";

            }        
        }
    }
}
