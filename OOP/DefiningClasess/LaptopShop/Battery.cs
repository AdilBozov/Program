using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopShop
{
    class Battery
    {
        private string generalInfo;
        private string life;

        public string GeneralInfo
        { 
            get 
            {
                return this.generalInfo;
            }
            set 
            {
                if(value == "")
                {
                    throw new ArgumentException("The value should be a non-empty string", "Battery name");
                }
            }
        }
        public string Life
        {
            get
            {
                return this.life;
            }
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("The value should be a non-empty string", "Battery life");
                }
            }
        }
    }
}
