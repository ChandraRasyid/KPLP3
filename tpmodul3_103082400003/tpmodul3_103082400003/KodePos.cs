using System;
using System.Collections.Generic;
using System.Text;

namespace tpmodul3_103082400003
{
    internal class KodePos
    {
        private string[,] listKodePos= {
                { "Batununggal  ", "40266" },
                { "Kujangsari   ", "40287" },
                { "Mengger      ", "40267" },
                { "Wates        ", "40256" },
                { "Cijaura      ", "40287" },
                { "Jatisari     ", "40286" },
                { "Margasari    ", "40286" },
                { "Sekejati     ", "40286" },
                { "Kebonwaru    ", "40272" },
                { "Maleer       ", "40274" },
                { "Samoja       ", "40273" }
        };
        public string[,] getKodePos()
        {
            return listKodePos; 
        }
    }
}
