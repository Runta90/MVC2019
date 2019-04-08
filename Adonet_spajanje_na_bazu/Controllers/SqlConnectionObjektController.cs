using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Adonet_spajanje_na_bazu.Controllers
{
    public class SqlConnectionObjektController : Controller
    {
        // GET: SqlConnectionObjekt
        public ActionResult Index()
        {
            // Prvo kreiramo conn string
            string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=dbAlgebra;Integrated Security=True";

            // Nakon toga instanca Sqlconnection
            SqlConnection conn = new SqlConnection(connString);

            // Otvaramo vezu s bazom
            try
            {
                conn.Open();
                if(conn.State == System.Data.ConnectionState.Open)
                {
                    Response.Write("Konekcija je uspjela.");
                }
            }
            catch (SqlException sqex)
            {
                Response.Write("Greška spajanja na bazu" + sqex.Message);
            }

            catch (Exception ex)
            {
                Response.Write("Neka greška" + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return View();
        }


    }
}