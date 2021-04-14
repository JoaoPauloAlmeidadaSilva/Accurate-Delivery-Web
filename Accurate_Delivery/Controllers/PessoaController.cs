using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Accurate_Delivery.Models;
using System.Data.SqlClient;

namespace Accurate_Delivery.Controllers
{

    public class PessoaController : Controller
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        [HttpGet]
        public ActionResult Login()
        {

            return View();
        }
        
        void ConnectionString()
        {
            con.ConnectionString = "data source = SD010241/SQLEXPRESS; database=Accurate_Delivery; integrated security = true";
        }
        
        public ActionResult Verificar(Pessoa acc)
        {
            ConnectionString();
            con.Open();
            com.Connection = con;
            com.CommandText = "SELECT * FROM pessoa where email='"+acc.Email+"' and senha_acesso'"+acc.SenhaAcesso+"'";
            dr = com.ExecuteReader();

            if (dr.Read())
            {

                con.Close();
                return View("Login");
            }
            else
            {
                con.Close();
                return View("Erro");
            }
            
        }
    }
}