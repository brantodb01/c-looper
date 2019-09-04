using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace LoopyLoppMan
{
    class heyHiImJustAConfigGuy
    {
        //default
        
        string pyooo = "pyloopy.txt";
        string csharow = "c#loopy.txt";
        string pythonDFAULT = "python > c#";
        string csharoused = "c# rulz";

        //default but can't be changed in config

        string homeAndAway = "loopyloop";
        string configment = "config.txt";



        string elDorado = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        string fountainOfYouth;
        string dePotosi;

        public heyHiImJustAConfigGuy()
        {
            fountainOfYouth = trueName(elDorado, homeAndAway);
            dePotosi = trueName(fountainOfYouth, configment);
        }







        //Methods

        public void haveWeMet()
        {
            if (File.Exists(dePotosi))
            {
                theMythsWereTrue();
            }
            else
            {
                weBuiltThisCity();
            }
        }

        public string trueName(string whereTheHearthIs, string theChosen )
        {
            return string.Format(@"{0}\{1}", whereTheHearthIs, theChosen);

        }



        public void weBuiltThisCity()
        {
            using (StreamWriter bob = new StreamWriter(dePotosi))
            {
                bob.WriteLine(string.Format("Python File Name(include.txt)={0}",pyooo));
                bob.WriteLine(string.Format("c# File Name(include.txt)={0}", csharow));
                bob.WriteLine(string.Format("Python message={0}",pythonDFAULT));
                bob.WriteLine(string.Format("c# message={0}",csharoused));
            }
        }

        public void theMythsWereTrue()
        {
            using (StreamReader bobita = new StreamReader(dePotosi))
            {
                pyooo = decryptionWithLove(bobita.ReadLine());
                csharow = decryptionWithLove(bobita.ReadLine());
                pythonDFAULT = decryptionWithLove(bobita.ReadLine());
                csharoused = decryptionWithLove(bobita.ReadLine());
            }
        }

        public string decryptionWithLove(string bond)
        {
            return bond.Split('=')[1];
        }


        //getters

        public string embezzlingMyMansionFund()
        {
            return homeAndAway;
        } 

        public string cortez()
        {
            return fountainOfYouth;
        }

        public string snakesOnAPlane()
        {
            return pyooo;
        }

        public string pianoMan()
        {
            return csharow;
        }
        
        public string noU()
        {
            return csharoused;
        }
    }
}
