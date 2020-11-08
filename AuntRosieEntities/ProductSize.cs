using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AuntRosieEntities
{
    public class ProductSize : IRosieEntity
    {
        private byte id;
        private string name;
        private string unit;
        private double value;
    }
}