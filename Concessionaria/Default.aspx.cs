using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Concessionaria
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Concessionaria"].ConnectionString.ToString();
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT Marca_modello FROM Macchina";

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ListItem lst = new ListItem((string)reader["Marca_modello"]);
                    DropDownList1.Items.Add(lst);

                }
            }
            catch (Exception )
            {

                Response.Write("Errore");
              
            }
            finally
            {
                conn.Close();
            }

        }




        protected void Stampa_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Concessionaria"].ConnectionString.ToString();
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open(); //apriamo la connessione




                SqlCommand cmd = new SqlCommand(); 
                cmd.Connection = conn; 
                cmd.CommandText = "SELECT Marca_modello,Prezzo_base FROM Macchina";


                

                SqlDataReader reader = cmd.ExecuteReader();
               
             

               
            }
            catch
            {
               

            }
            finally
            {
                conn.Close();
            }
        }



    }
}