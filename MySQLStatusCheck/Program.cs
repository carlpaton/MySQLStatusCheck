using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySQLStatusCheck
{
    class Program
    {
        static void Main(string[] args)
        {

            //SHOW STATUS WHERE `variable_name` = 'Threads_connected';
            //show session status;


            int connections = 1500;




            try
            {
                while (connections > 0)
                {
                    //new ConnectionCounter().DoConnect();
                    new ConnectionCounter().DoConnectWithUsing();
                    connections--;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            string stop = "";
        }
    }
}
