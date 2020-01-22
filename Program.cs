using System;
using System.Data;


class Program
{
    static void Main()
    {


        Console.WriteLine("Hello World!");
        int asko = 1;

        asko = asko + 1;
        Console.WriteLine(asko);
        var res = func();
        Console.WriteLine(res.Tables[0].Rows[0][0]);


        DataSet func(){

            var ds = new DataSet();
            var dt = new DataTable[]{new DataTable("table1"), new DataTable("table2")};
            ds.Tables.AddRange(dt);
            var dc = new DataColumn[]{new DataColumn("nimi",typeof(string)), new DataColumn("ikä",typeof(int))};
            ds.Tables["table1"].Columns.AddRange(dc);

            var dr = ds.Tables["table1"].NewRow();
            dr[0] = "janne";
            dr[1] = 140;
            ds.Tables["table1"].Rows.Add(dr);

            return ds;
        }
    

    }
}
