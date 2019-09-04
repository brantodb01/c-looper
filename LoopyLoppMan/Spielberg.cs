using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace LoopyLoppMan
{
    class Spielberg
    {
        heyHiImJustAConfigGuy configuritout;

        public Spielberg(heyHiImJustAConfigGuy configerinator)
        {
            configuritout = configerinator;
            
            bootCheck();
            configerinator.haveWeMet();
        }



        public void bootCheck()
        {
            if(File.Exists(configuritout.cortez()) == true)
            {
                //get out
            }
            else
            {
                Directory.CreateDirectory(configuritout.cortez());
            }
        }



    }
}
