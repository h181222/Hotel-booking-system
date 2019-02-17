﻿using SQLConnectionApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SQLConnectionApplication.DataProviders
{
   public class RomDataprovider
    {

        public Rom FinnRom(int romNummer)
        {
            Rom rom;
            using (var context = new DatabaseContext())
            {
                 rom = context.Rom.Where(r => r.RomID == romNummer).FirstOrDefault();
            }

            return rom;
        }

        public List<Rom> FinnAlleRom()
        {
            using (var context = new DatabaseContext())
            {
                return context.Rom.ToList();
            }
        }

        


    }
}
