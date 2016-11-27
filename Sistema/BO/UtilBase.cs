using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.BO
{
    public class UtilBase
    {
        public bool validateName (String name)
        {
            if (String.IsNullOrEmpty(name))
            {
                return false;
            }

            if (name.Length < 7)
            {
                return false;
            }

            return true;
        }
    }
}
