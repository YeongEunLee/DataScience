using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;

namespace _201811527_patent
{
    public class Patent
    {
        public string num;
        public string date;
        public string title;
        public string abst;
        public string inventors;
        public string cpcs;
        public Patent(string num, string date, string title, string abst, string inventors, string cpcs)
        {
            this.num = num;
            this.date = date;
            this.title = title;
            this.abst = abst;
            this.inventors = inventors;
            this.cpcs = cpcs;
        }
        public DataRow getDatarow(DataTable datatable)  //해당 객체의 정보를 DataRow의 형태로 Return.
        {
            DataRow dr = datatable.NewRow();
            dr[0] = num;
            dr[1] = date;
            dr[2] = title;
            dr[3] = abst;
            dr[4] = inventors;
            dr[5] = cpcs;

            return dr;
        }
    }
}
