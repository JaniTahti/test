﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraafisenKäyttöliittymä
{
    class Yhdistä
    {
        public string yhteyslause()
        {
            return "datasource = localhost; port=3306;username=root;password=;database=opiskelija; SSL Mode = NONE";
        }
        private MySqlConnection yhteys = new MySqlConnection("datasource = localhost; port=3306;username=root;password=;database=opiskelija; SSL Mode = NONE");

        public MySqlConnection otaYhteys()
        {
            return yhteys;
        }

        public void avaaYhteys()
        {
            if (yhteys.State == ConnectionState.Closed)
            {
                yhteys.Open();
            }
        }

        public void suljeYhteys()
        {
            if (yhteys.State == ConnectionState.Open)
            {
                yhteys.Close();
            }
        }
    }
}
