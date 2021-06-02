using System;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace DotNetDapperExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (IDbConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Mshowto;Integrated Security=True;"))
            //{
            //    conn.Open();

            //    conn.Execute(
            //        "insert into Customer(Name,Surname) values (@name,@surname)",new Customer { Name="Adem",Surname=",Coşkun"}
            //        );

            //    List<Customer> customersList = conn.Query<Customer>("select * from Customer").ToList();
            //    conn.Close();
            //}

            DapperRepository microOrm = new DapperRepository();
            var result = microOrm.Connection.Query<Customer>("select * from customer").ToList();
            foreach (var item in result)
            {
                Console.WriteLine(item.Name + " " + item.Surname);
            }
            Console.ReadKey();
        }
    }
}
