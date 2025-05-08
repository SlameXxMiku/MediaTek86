using System;
using System.Collections.Generic;
using System.Linq;
using MediaTek86.bddmanager;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;   
using System.Data.SqlClient;
using System.Configuration;

namespace MediaTek86.dal
    {

    public class Access
        {

        private static readonly string connectionName = "MediaTek86.Properties.Settings.MediaTek86ConnectionString";
        private static Access instance = null;
        public BddManager Manager { get; }

        private Access()
            {
            string connectionString = GetConnectionStringByName(connectionName);
            if (string.IsNullOrEmpty(connectionString))
                { 
                    throw new Exception("Erreur : Chaine de connexion introuvable");
                }
            Manager = BddManager.GetInstance(connectionString);

            }
        public static Access GetInstance()
            {
            if (instance == null)
                {
                instance = new Access();
                }
            return instance;
            }
        static string GetConnectionStringByName(string name)
            {
                ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[name];
                return settings?.ConnectionString ?? string.Empty;

            }

        }
    }
