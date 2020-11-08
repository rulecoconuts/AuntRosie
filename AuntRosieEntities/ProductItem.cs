using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AuntRosieEntities
{
    public class ProductItem : RosieEntity
    {
        private int id;
        private byte sizeID;
        private double price;
        private short productID;

        public Product Product
        {
            get => default;
            set
            {
            }
        }

        public ProductSize ProductSize
        {
            get => default;
            set
            {
            }
        }
    }
}