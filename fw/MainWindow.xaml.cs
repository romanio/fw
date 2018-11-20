using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using System.Windows.Forms.DataVisualization.Charting;

namespace fw
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        MainWindowModel model = new MainWindowModel();

        public MainWindow()
        {
            DataContext = model;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog fileDialog = new Microsoft.Win32.OpenFileDialog() { Filter = "BDExcel|*.xlsx" };
            if (fileDialog.ShowDialog() == true)
            {
                model.OpenBDExcel(fileDialog.FileName);
            }

        }

        List<string> SelectedLayers = new List<string>();
        List<string> SelectedWells = new List<string>();

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var tmp = (sender as ListBox).SelectedItems;
            SelectedWells.Clear();

            foreach (object item in tmp)
            {
                SelectedWells.Add(item.ToString());
            }
            UpdateChart();
        }

        private void ListBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            SelectedLayers.Clear();
            var tmp = (sender as ListBox).SelectedItems;
            foreach (object item in tmp)
            {
                SelectedLayers.Add(item.ToString());
            }
            UpdateChart();
        }

        void UpdateChart()
        {
            if (SelectedLayers.Count == 0) return;
            if (SelectedWells.Count == 0) return;

            model.UpdateChart(SelectedLayers, SelectedWells);

            // Generate chart title

            /*
            if (checkRates.IsChecked.Value)
            {
                chart.ChartAreas[0].AxisY.Title = "[m3/day]";
            }
            else
            {
                chart.ChartAreas[0].AxisY.Title = "[m3]";
            }


            //
            chart.ChartAreas[0].AxisY.Minimum = double.NaN;
            chart.ChartAreas[0].AxisY.Maximum = double.NaN;
            chart.ChartAreas[0].AxisX.Minimum = double.NaN;
            chart.ChartAreas[0].AxisX.Maximum = double.NaN;
            chart.ChartAreas[0].RecalculateAxesScale();


            // GTM
            for (int it = 0; it < model.dates.Count; ++it)
            {
                if (res[it] != null)
                {
                    if (res[it].gtm != null)
                    {
                        if (res[it].liquid > 0)
                        {
                            chart.Series[1].Points[it].MarkerStyle = MarkerStyle.Circle;
                            chart.Series[1].Points[it].MarkerSize = 7;
                            chart.Series[1].Points[it].MarkerColor = System.Drawing.Color.LawnGreen;
                            chart.Series[1].Points[it].Label = res[it].gtm;
                        }
                        if (res[it].winj > 0)
                        {
                            chart.Series[3].Points[it].MarkerStyle = MarkerStyle.Circle;
                            chart.Series[3].Points[it].MarkerSize = 7;
                            chart.Series[3].Points[it].MarkerColor = System.Drawing.Color.LawnGreen;
                            chart.Series[3].Points[it].Label = res[it].gtm;
                        }
                    }
                }
            }

            // Layers

            double from_pos = 0;
            double to_pos = 0;

            string layer = null;

            chart.ChartAreas[0].AxisX.CustomLabels.Clear();

            for (int it = 0; it < model.dates.Count; ++it)
            {
                if (res[it] != null)
                {
                    if (layer == null) // Первая встреча
                    {
                        layer = res[it].layer;
                        from_pos = model.dates[it].ToOADate();
                    }
                    else // Не первая встреча
                    {
                        if (res[it].layer == layer) // Тот-же пласт
                        {
                            to_pos = model.dates[it].ToOADate();
                        }
                        else // Какой-то другой пласт
                        {
                            chart.ChartAreas[0].AxisX.CustomLabels.Add(from_pos, to_pos, layer, 1, LabelMarkStyle.LineSideMark);
                            layer = res[it].layer;
                            from_pos = model.dates[it].ToOADate();
                        }
                    }
                }
                else // Если null, то надо закрывать скобку
                {
                    if (layer != null)
                    {
                        chart.ChartAreas[0].AxisX.CustomLabels.Add(from_pos, to_pos, layer, 1, LabelMarkStyle.LineSideMark);
                        layer = null;
                    }
                }
            }

            if (layer != null)
            {
                chart.ChartAreas[0].AxisX.CustomLabels.Add(from_pos, to_pos, layer, 1, LabelMarkStyle.LineSideMark);
            }
            */
        }
        
        private void checkRates_Click(object sender, RoutedEventArgs e)
        {
            UpdateChart();
        }
    }
}
