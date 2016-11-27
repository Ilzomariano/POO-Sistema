using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.BO
{
    public interface IPersistence
    {
        void save<T>(T obj);
    }
}
