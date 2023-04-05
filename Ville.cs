﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Box
{
    public class Ville
    {
        private int idVille;
        public int IdVille
        {
            get { return idVille; }
            set { idVille = value; }
        }
        private string nomVille;
        public string NameVille
        {
            get { return nomVille; }
            set { nomVille = value; }
        }
        private string cp;
        public string Cp
        {
            get { return cp; }
            set { cp = value; }
        }
        private List<Garage> garages = new List<Garage>();
        public List<Garage> Garages
        {
            get { return garages; }
            set { garages = value; }

        }
    }
}
