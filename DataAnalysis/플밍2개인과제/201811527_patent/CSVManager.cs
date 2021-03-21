using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;

namespace _201811527_patent
{
    class CSVManager
    {
        public DataTable datatable;

        public CSVManager(string filepath)
        {
            this.datatable = new DataTable();

            string[] header;
            string[] records;

            records = File.ReadAllLines(filepath, Encoding.Default);

            header = records[0].Split(',');

            for (int i = 0; i < header.Length; i++)
            {
                datatable.Columns.Add(header[i]);
            }
            for (int i = 1; i < records.Length; i++)
            {
                string line = records[i];

                Patent patent = new Patent(line.Split(',')[0], line.Split(',')[1], line.Split(',')[2], line.Split(',')[3], line.Split(',')[4], line.Split(',')[5]);
                datatable.Rows.Add(patent.getDatarow(datatable));
            }
        }
    }
}
