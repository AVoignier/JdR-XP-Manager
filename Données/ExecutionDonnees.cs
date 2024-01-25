using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace WindowsFormsApp1
{
    internal class ExecutionDonnees
    {
        private static ExecutionDonnees instance;
        private static SqlCommand commande;
        private static string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\alexv\\source\\repos\\WindowsFormsApp1\\BD_Test.mdf;Integrated Security=True;Connect Timeout=30";
        //private static string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=BD_Test.mdf;Integrated Security=True;Connect Timeout=30";
        private static SqlConnection connection;

        private ExecutionDonnees()
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
            }
            catch(SqlException e)
            {
                Console.WriteLine(e.Message);
                Environment.Exit(0);
            }

            Console.WriteLine("Connexion établie");
        }

        public static ExecutionDonnees GetInstance() 
        {
            if (instance == null)
            {
                instance = new ExecutionDonnees();
            }

            return instance;
        }

        public SqlDataReader RequeteReader(string req)
        {
            Console.WriteLine("cmd reader : " + req);

            commande = new SqlCommand(req,connection);
            commande.Prepare();
            return commande.ExecuteReader();

        }

        public SqlDataReader RequeteReader(string req,Dictionary<string,object> parametres)
        {
            Console.WriteLine("cmd reader param : " + req);

            commande = new SqlCommand(req, connection);
            foreach(KeyValuePair<string,object> param in parametres)
            {
                commande.Parameters.AddWithValue(param.Key, param.Value);
            }

            //commande.Prepare();
            return commande.ExecuteReader();

        }

        public void RequeteInsert(string req, Dictionary<string, object> parametres)
        {
            Console.WriteLine( "cmd insert : " + req);

            commande = new SqlCommand(req, connection);
            foreach (KeyValuePair<string, object> param in parametres)
            {
                commande.Parameters.AddWithValue(param.Key, param.Value);
            }

            //commande.Prepare();
            commande.ExecuteNonQuery();

        }

        public void RequeteUpdate(string req, Dictionary<string, object> parametres)
        {
            Console.WriteLine("cmd update : " + req);

            commande = new SqlCommand(req, connection);
            foreach (KeyValuePair<string, object> param in parametres)
            {
                commande.Parameters.AddWithValue(param.Key, param.Value);
            }

            //commande.Prepare();
            commande.ExecuteNonQuery();

        }

        public void RequeteDelete(string req, Dictionary<string,object> parametres)
        {
            Console.WriteLine("cmd delete : " + req);

            commande = new SqlCommand(req, connection);
            foreach (KeyValuePair<string, object> param in parametres)
            {
                commande.Parameters.AddWithValue(param.Key, param.Value);
            }

            //commande.Prepare();
            commande.ExecuteNonQuery();
        }



    }
}
