﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Toteuta ohjelma, jossa voidaan näyttää lasku ostetuista tavaroista.

            Jokaisesta ostetusta tavarasta tulee käsitellä seuraavat tiedot: nimi, hinta ja määrä.

            Toteutetun luokan tulee osata palauttaa tieto siitä paljonko ko. ostetut tavarat
            kokonaisuudessaan maksavat (hinta*määrä). Toteuta myös ToString()-metodi,
            joka palauttaa tuotteen nimen, hinnan ja määrät merkkijonona.
    
            Toteuta luokka, joka pitää sisällään List-rakenteessa yllä määriteltyjä tuotteita.
            Luokan tulee pystyä kertomaan myös asiakkaan nimi, paljonko "laskulla" on yhteensä
            tuotteita sekä niihin kuluva rahan määrä kokonaisuudessaan.
    
            Toteuta pääohjelma ja määrittele laskulle tavaroita ja ostajan nimi.
    
            Invoice-luokan kokonaissumman (total) testaaminen

            Testaa yksikkötestauksen avulla, että laskulle määritelty kokonaissumma varmasti lasketaan oikein.
            */

            try
            {
                paaOhjelma();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void paaOhjelma ()
        {
            try
            {

            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
