using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Ho_So_SV.SET
{
    class DataProvider
    {
        private string connectionSTR = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyHoSoSinhVien;Integrated Security=True";
        public DataTable ExcuteQuery(string query)
        {
            SqlConnection connection = new SqlConnection(connectionSTR);

                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                DataTable data = new DataTable();

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);

                connection.Close();
            return data;

        }
    }
    class KetNoi
    {
        public static string str = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyHoSoSinhVien;Integrated Security=True";
    }
}
