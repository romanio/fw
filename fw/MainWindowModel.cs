using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.Axes;
using System.Data;
using System.Collections;
using System.Collections.ObjectModel;

namespace fw
{
    class MainWindowModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        public MainWindowModel()
        {
            OxyModel = new OxyPlot.PlotModel();
          
            OxyModel.Axes.Add(new DateTimeAxis
            {
                Font = "Segoe UI",
                Position = AxisPosition.Bottom
            });

            OxyModel.Axes.Add(new LinearAxis
            {
                Font = "Segoe UI",
                Position = AxisPosition.Left
            });

            OxyModel.LegendFont = "Segoe UI";
            OxyModel.TitleFont = "Segoe UI";
            OxyModel.TitleFontSize = 14;
            OxyModel.Series.Add(new LineSeries { Title = "Oil" });
            OxyModel.Series.Add(new LineSeries { Title = "Liquid" });

            wellnames = new List<string>()
            {
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin",
                "Sergo",
                "Pablo",
                "Konstantin"
            };

        }

        // Внешние массивы

        public List<DateTime> dates = new List<DateTime>();
        public List<string> wellnames { get; set; }
        public List<string> wellbores { get; set; }
        public List<string> layers { get; set; }
        public List<string> pads { get; set; }

        public PlotModel OxyModel { get; set; }
        public bool IsRateProduction { get; set; }
        public  List<object[]> Cells { get; set; } = new List<object[]>();


        // Возвращает данные по одной скважине

        public Record[] GetWellData(string wellname, string layer)
        {
            Record[] d = new Record[dates.Count];

            var tmp =
                (from item in bde.data
                 where item.wellname == wellname && item.layer == layer
                 select item).ToList();

            foreach (Record item in tmp)
            {
                int tindex = dates.IndexOf(item.date);
                d[tindex] = item;
            }
            return d;
        }

        // Возвращает данные по группе скважин и пластов

       
        public Record[] GetData(string[] wellnames, string[] layers)
        {
            Record[] data = new Record[dates.Count];

            for (int it = 0; it < dates.Count; ++it)
                data[it] = new Record();

            Record[,] data_tmp = new Record[wellnames.Length, dates.Count];
            for (int iw = 0; iw < wellnames.Length; ++iw)
                for (int it = 0; it < dates.Count; ++it)
                    data_tmp[iw, it] = new Record();

            List<string>[] layers_list = new List<string>[dates.Count];
            for (int it = 0; it < layers_list.Length; ++it)
                layers_list[it] = new List<string>();

            List<string>[] gtm_list = new List<string>[dates.Count];
            for (int it = 0; it < gtm_list.Length; ++it)
                gtm_list[it] = new List<string>();


            for (int iw = 0; iw < wellnames.Length; ++iw)
            {
                // Сложить данные по одной скважине по всем пластам
                for (int id = 0; id < layers.Length; ++id)
                {
                    var tmp = GetWellData(wellnames[iw], layers[id]);
                    for (int it = 0; it < dates.Count; ++it)
                        if (tmp[it] != null)
                        {
                            data_tmp[iw, it].bhp = tmp[it].bhp; // Для всех пластов забойное должно быть одно
                            data_tmp[iw, it].days = tmp[it].days; // Для всех пластов количество суток тоже одно
                            data_tmp[iw, it].liquid = data_tmp[iw, it].liquid + tmp[it].liquid;
                            data_tmp[iw, it].oil = data_tmp[iw, it].oil + tmp[it].oil;
                            data_tmp[iw, it].shdays = data_tmp[iw, it].shdays + tmp[it].shdays;
                            data_tmp[iw, it].winj = data_tmp[iw, it].winj + tmp[it].winj;
                            layers_list[it].Add(tmp[it].layer);
                            if (tmp[it].gtm != "")
                                gtm_list[it].Add(tmp[it].gtm);
                        }
                }
            }

            for (int it = 0; it < dates.Count; ++it)
            {
                for (int iw = 0; iw < wellnames.Length; ++iw)
                {
                    data[it].liquid = data[it].liquid + data_tmp[iw, it].liquid;
                    data[it].oil = data[it].oil + data_tmp[iw, it].oil;
                    data[it].winj = data[it].winj + data_tmp[iw, it].winj;
                    data[it].days = data[it].days + data_tmp[iw, it].days;
                    data[it].shdays = data[it].shdays + data_tmp[iw, it].shdays;
                }

               var layers_short = layers_list[it].Distinct().ToList();
               foreach(string item in layers_short)
                {
                    data[it].layer = data[it].layer + ";" + item;
                }

                if (data[it].layer != null) data[it].layer = data[it].layer.Substring(1, data[it].layer.Length - 1);

                var gtm_short = gtm_list[it].Distinct().ToList();
                foreach (string item in gtm_short)
                {
                    data[it].gtm = data[it].gtm + ";" + item;
                }

                if (data[it].gtm != null)
                    data[it].gtm = data[it].gtm.Substring(1, data[it].gtm.Length - 1);
            }
            return data;
        }

        BDExcel bde = new BDExcel();
        public void OpenBDExcel(string filename)
        {
            bde.OpenFile(filename);

            DateTime date_min = bde.data.Min(c => c.date);
            DateTime date_max = bde.data.Max(c => c.date);
            DateTime date = date_min;

            while (date <= date_max)
            {
                dates.Add(date);
                date = date.AddMonths(1);
            }

            wellnames =
                (from item in bde.data
                 select item.wellname).Distinct().ToList();

            OnPropertyChanged("wellnames");

            layers =
                (from item in bde.data
                 select item.layer).Distinct().ToList();

            OnPropertyChanged("layers");

            wellbores =
                (from item in bde.data
                 select item.wellbore).Distinct().ToList();

            pads =
                (from item in bde.data
                 select item.pad).Distinct().ToList();
        }

        public void UpdateChart(List<string> SelectedLayers, List<string> SelectedWells)
        {
           
            // Local function
            Func<Record, double> wcut = (tmp) =>
            {
                if (tmp.liquid == 0)
                    return 0;
                else
                    return 100 * (1 - tmp.oil / tmp.liquid);
            };
            // ****

            string title = "Well " + SelectedWells[0];
            for (int iw = 1; iw < SelectedWells.Count; ++iw)
                title = title + "-" + SelectedWells[iw];

            OxyModel.Title = title;

            var res = GetData(SelectedWells.ToArray(), SelectedLayers.ToArray());

            ((LineSeries)OxyModel.Series[0]).Points.Clear(); // Oil
            ((LineSeries)OxyModel.Series[1]).Points.Clear(); // Liquid
            /*
            chart.Series[0].Points.Clear(); // Oil
            chart.Series[1].Points.Clear();
            chart.Series[2].Points.Clear(); // Water-Cut
            chart.Series[3].Points.Clear(); // Injection
            chart.Series[4].Points.Clear(); // BHP
            chart.Series[5].Points.Clear();  //Days
            */
            Cells.Clear();

            for (int it = 0; it < dates.Count; ++it)
            {
               // RowHeaders.Add(it + 1);

                if (res[it] == null)
                {
                    ((LineSeries)OxyModel.Series[0]).Points.Add(new DataPoint(DateTimeAxis.ToDouble(dates[it]), 0)); // Oil
                    ((LineSeries)OxyModel.Series[1]).Points.Add(new DataPoint(DateTimeAxis.ToDouble(dates[it]), 0));  // Liquid


                     Cells.Add(new object[3] { dates[it].ToShortDateString(), 0, 0});
                    //chart.Series[2].Points.AddXY(model.dates[it], 0); // Water-Cut
                    //chart.Series[3].Points.AddXY(model.dates[it], 0); // Injection
                    //chart.Series[4].Points.AddXY(model.dates[it], 0); // BHP
                    //chart.Series[5].Points.AddXY(model.dates[it], 0);  //Days
                }
                else
                {
                    if (IsRateProduction)
                    {
                        if (res[it].days == 0)
                        {
                            ((LineSeries)OxyModel.Series[0]).Points.Add(new DataPoint(DateTimeAxis.ToDouble(dates[it]), 0));
                            ((LineSeries)OxyModel.Series[1]).Points.Add(new DataPoint(DateTimeAxis.ToDouble(dates[it]), 0));

                            /*
                            chart.Series[1].Points.AddXY(model.dates[it], 0);
                            chart.Series[3].Points.AddXY(model.dates[it], 0);
                            */
                        }
                        
                        else
                        {
                            ((LineSeries)OxyModel.Series[0]).Points.Add(new DataPoint(DateTimeAxis.ToDouble(dates[it]), res[it].oil / res[it].days));
                            ((LineSeries)OxyModel.Series[1]).Points.Add(new DataPoint(DateTimeAxis.ToDouble(dates[it]), res[it].liquid / res[it].days));

                            /*

                            chart.Series[1].Points.AddXY(model.dates[it],
                            chart.Series[3].Points.AddXY(model.dates[it], res[it].winj / res[it].days);
                            */
                        }
                    }
                    else
                    {
                        Cells.Add(new object[3] { dates[it].ToShortDateString(), res[it].oil, res[it].liquid });
                        ((LineSeries)OxyModel.Series[0]).Points.Add(new DataPoint(DateTimeAxis.ToDouble(dates[it]), res[it].oil));
                        ((LineSeries)OxyModel.Series[1]).Points.Add(new DataPoint(DateTimeAxis.ToDouble(dates[it]), res[it].liquid));
                        /*

                        chart.Series[1].Points.AddXY(model.dates[it], res[it].liquid);
                        chart.Series[3].Points.AddXY(model.dates[it], res[it].winj);
                        */
                    }
                    /*
                    chart.Series[2].Points.AddXY(model.dates[it], wcut(res[it]));
                    chart.Series[4].Points.AddXY(model.dates[it], res[it].bhp);
                    chart.Series[5].Points.AddXY(model.dates[it], res[it].days);
                    */
                }
            }


            OxyModel.InvalidatePlot(true);
            OnPropertyChanged("OxyModel");
            OnPropertyChanged("Cells");
        }
    }
}
