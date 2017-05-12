using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDemos
{
    public class Class1
    {
        public Class1()
        {
          
        }

      

        public static string getString()
        {

            return Properties.Settings1.Default.ll;
         
        }

        public static void SaveThe()
        {
           // Properties.LibrarySetting.Default.ISerove = "23232323";
          
           // Properties.LibrarySetting.Default.Save();
            Properties.Settings1.Default.Upgrade();
        }
    }
}
