using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ExcelDataReader;

namespace fw
{
    public class Record
    {
        public string wellname;
        public string wellbore;
        public DateTime date;
        public string layer;
        public string pad;
        public double liquid;
        public double oil;
        public double winj;
        public double bhp;
        public double thp;
        public double days;
        public double shdays;
        public string gtm;
    }

    public class BDExcel
    {
        public List<Record> data = new List<Record>();

        object GetValue(object value)
        {
            if (DBNull.Value.Equals(value))
                return null;
            else
                return value;
        }

        public void OpenFile(string filename)
        {
            using (var stream = File.Open(filename, FileMode.Open))
            using (var reader = ExcelReaderFactory.CreateReader(stream))
            {
                var result = reader.AsDataSet();

                for (int iw = 1; iw < result.Tables["BD"].Rows.Count - 1; ++iw)
                {
                    var row = result.Tables["BD"].Rows[iw];

                    if (GetValue(row[0]) != null)
                        data.Add(new Record
                        {
                            date = Convert.ToDateTime(row[0]),
                            wellname = row[1].ToString(),
                            wellbore = row[2].ToString(),
                            layer = row[3].ToString(),
                            pad = row[4].ToString(),
                            liquid = Convert.ToDouble(GetValue(row[5]) ?? 0),
                            oil = Convert.ToDouble(GetValue(row[6]) ?? 0),
                            winj = Convert.ToDouble(GetValue(row[7]) ?? 0),
                            bhp = Convert.ToDouble(GetValue(row[8]) ?? 0),
                            thp = Convert.ToDouble(GetValue(row[9]) ?? 0),
                            days = Convert.ToDouble(GetValue(row[10]) ?? 0),
                            shdays = Convert.ToDouble(GetValue(row[11]) ?? 0),
                            gtm = row[12].ToString() ?? ""
                        });
                }
            }
        }
    }
}