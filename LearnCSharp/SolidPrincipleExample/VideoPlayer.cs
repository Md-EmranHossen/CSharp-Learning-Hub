using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrincipleExample
{
    public class VideoPlayer
    {
        void play(string fileName)
        {

            FIleSystemUtility fIleSystemUtility = new FIleSystemUtility();
          Stream stream =   fIleSystemUtility.OpenFile(fileName);

        }
    }
}
