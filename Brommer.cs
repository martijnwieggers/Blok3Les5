﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blok3Les5
{
    public class Brommer
    {
        public string Merk { get; set; }

        //Voeg de volgende publieke eigenschappen toe:

        //Type (tekst)

        //AantalVersnellingen (geheel getal)

        //MaximumSnelheid (geheel getal)


        //Standard Constructor, deze is er altijd
        public Brommer() 
        { 
        }
        //Constructor waar alleen merk kan worden meegegeven, de rest van de eigenschappen blijft leeg
        public Brommer(string Merk)
        {
            this.Merk = Merk;
        }

        //Stap 4: Voeg een constructor toe waarbij alle waarden direct kunnen worden meegegeven


    }

   

}
