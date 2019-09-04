using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace LoopyLoppMan
{
    class theGreenFireHydrant
    {
        heyHiImJustAConfigGuy mrMan;

        string hiMyNameIs;
        string yourNameIs;


        public theGreenFireHydrant(heyHiImJustAConfigGuy whoWho)
        {
            mrMan = whoWho;

            hiMyNameIs = mrMan.trueName(mrMan.cortez(), mrMan.pianoMan());
            yourNameIs = mrMan.trueName(mrMan.cortez(), mrMan.snakesOnAPlane());
            knowMyName();

        }

        public void knowMyName()
        {
            if (File.Exists(hiMyNameIs))
            {
                ///buhbye
                Console.WriteLine("You shouldn't be here");
            }
            else 
            {
                if (File.Exists(yourNameIs))
                {
                    File.Delete(yourNameIs);
                }
                File.WriteAllText(hiMyNameIs, mrMan.noU());

                

            }

        }

    }
}
