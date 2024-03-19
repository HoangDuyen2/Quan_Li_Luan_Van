using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
namespace Quan_Li_Luan_Van
{

    internal class DSLuanVanDAO
    {
        static string conString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=Quan_Li_Luan_Van;Integrated Security=True;Encrypt=True";
        SqlCommand cmd;
        SqlConnection conn;
        SqlDataReader reader;

        public DSLuanVanDAO() 
        {
            conn = new SqlConnection(conString);
            cmd = new SqlCommand();
        }
        public bool connect ()
        {
            try
            {
                conn.Open();
                return true; 
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        public bool disconnection()
        {
            try
            {
                conn.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        public string getInfo(string query, FlowLayoutPanel panel)
        {
            string res="";
            try
            {
                cmd.Connection = conn;
                cmd.CommandText = query.ToLower();
                connect();

                reader = cmd.ExecuteReader();
                string tenLV, chuyenNganh, tenGV, SoLuong;
                while (reader.Read())
                {
                    tenLV = reader[0].ToString();
                    chuyenNganh = reader[1].ToString();
                    tenGV = reader[2].ToString();
                    SoLuong = reader[3].ToString();

                    UCLV uclv = new UCLV();

                    uclv.LblTenLV.Text = tenLV;
                    uclv.LblChuyenNganh.Text = chuyenNganh;
                    uclv.LblTenGV.Text = tenGV;
                    

                    if(tenLV != string.Empty)
                    {
                        panel.Controls.Add(uclv);
                    }
                }
                res = "v";
            }
            catch(Exception ex) 
            {
                res = ex.Message;
                throw;
            }
            return res;
        }
    }
}
