using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Invantory.ASP.GUI;
using Invantory.ASP.DataAccesses;

namespace Invantory.ASP.Business
{
  public  class Invantor
    {
        public int ID_Articl { get; set; }
        public string Name_Articl  { get; set; }
        public int Quntity_IN { get; set; }
        public int Price { get; set; }

        public int Quntity_Out { get; set; }
        public int Quntity_Exist { get { return Quntity_IN - Quntity_Out; } set => Quntity_Exist = value; }
        public int Total_Worth { get { return Quntity_Exist * Price; } set => Total_Worth = value; }
        

    }
    
}
