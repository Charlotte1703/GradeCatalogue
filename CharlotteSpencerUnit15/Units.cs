using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharlotteSpencerUnit15
{
    class Units
    {
        private string unitName;
        private int unitPoints;
       
        

        public Units(string unitName, int unitPoints)
        {
            this.unitName = unitName;
            this.unitPoints = unitPoints;
        }
        public string UnitName
        {
            get { return unitName; }
            set { unitName = value; }
        }
        
        public int UnitPoints
        {
            get { return unitPoints; }
            set { unitPoints = value; }
        }
        

        
        

       

    }

}


