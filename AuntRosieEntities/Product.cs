using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AuntRosieEntities
{
    public class Product : IRosieEntity
    {
        private short id;
        private string name;
        private string type;
        private string servingSize;
    }
}