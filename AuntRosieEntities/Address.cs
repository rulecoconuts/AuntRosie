using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AuntRosieEntities
{
    public class Address
    {
        private string province;
        private string city;
        private string street;

        public Address(string province, string city, string street)
        {
            this.province = province;
            this.city = city;
            this.street = street;
        }

        public string Province { get => province; set => province = value; }
        public string City { get => city; set => city = value; }
        public string Street { get => street; set => street = value; }

        public override string ToString()
        {
            return $"{(Street != null?$"{Street},":"")} {City??""} {Province??""}".Trim();
        }
    }
}