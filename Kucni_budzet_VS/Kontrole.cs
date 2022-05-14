using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Kucni_budzet_VS
{
    class Kontrole
    {
        static public SqlConnection Povezi()
        {
            string CS = ConfigurationManager.ConnectionStrings["kuca"].ConnectionString;
            SqlConnection veza = new SqlConnection(CS);
            return veza;
        }

        static public int Provera_Korisnika(string email, string lozinka)
        {
            SqlCommand komanda = new SqlCommand();

            int rezultat = 0;

            SqlConnection veza = Povezi();
            komanda.Connection = veza;
            komanda.CommandType = CommandType.StoredProcedure;
            komanda.CommandText = "Provera_Korisnika";

            komanda.Parameters.Add(new SqlParameter("@email", SqlDbType.VarChar, 70, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Current, email));
            komanda.Parameters.Add(new SqlParameter("@lozinka", SqlDbType.VarChar, 30, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Current, lozinka));
            komanda.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, true, 0, 0, "", DataRowVersion.Current, null));

            veza.Open();
            komanda.ExecuteNonQuery();
            veza.Close();

            rezultat = (int) komanda.Parameters["@RETURN_VALUE"].Value;

            return rezultat;
        }
    }
}
