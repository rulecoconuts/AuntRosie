using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AuntRosieEntities
{
    public class Production
    {
        private long id;
        private int productItemID;
        private DateTime productionDate;
        private short quantity;
        private DateTime expiryDate;

        public ProductItem ProductItem
        {
            get => default;
            set
            {
            }
        }
    }
}