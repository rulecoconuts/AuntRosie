using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Faker;
using AuntRosieEntities;

namespace GenerateData
{
    class Program
    {
        static void Main(string[] args)
        {
            String DatabasePath = @"C:\Users\rulec\OneDrive\Documents\AuntRosieUserInterface\AuntRosieApplication\bin\Debug";
            int x = DatabasePath.IndexOf("bin");
            DatabasePath = DatabasePath.Substring(0, x - 1);
            String conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + DatabasePath +
              @"\AuntRosieDB.mdf;Integrated Security=True;Connect Timeout=30";
            DBConnector conn = new DBConnector(conStr);
            RosieEntity.Connector = conn;
            
            GenProduction(30);
            Console.ReadLine();
            conn.Disconnect();
        }

        private static void GenSupplier(int nRecords)
        {
            for(int i = 0; i < nRecords; i++)
            {
                Supplier insertSupplier = new Supplier();
                insertSupplier.Name = Company.Name();
                insertSupplier.ContactFirstName = Name.First();
                insertSupplier.ContactLasttName = Name.Last();
                insertSupplier.Phone = Phone.Number();
                insertSupplier.Email = Internet.Email();
                insertSupplier.City = Faker.Address.City();
                insertSupplier.Province = "ON";
                insertSupplier.Street = Faker.Address.StreetAddress();
                //insertSupplier.PostalCode = txtPostalCode.Text.Trim();
            }
        }

        private static void GenProduction(int nRecords)
        {
            List<ProductItem> productItems = ProductItem.GetProductItems();
            int count = productItems.Count;
            Random randGen = new Random();

            for (int i = 0; i < nRecords; i++)
            {
                ProductItem slctPrdItem = productItems[randGen.Next(0, count - 1)];
                Production productionToBeCreated = new Production();
                productionToBeCreated.ProductItemID = slctPrdItem.Id;
                productionToBeCreated.Quantity = (short)randGen.Next(0, 200);
                //Set valid dates
                productionToBeCreated.ProductionDate = DateTime.Now.AddDays(-1 * randGen.Next(0, nRecords))
                    .AddHours(-1 * randGen.Next(0, 12)).AddMinutes(-1 * randGen.Next(0, 30));
                productionToBeCreated.ExpiryDate = DateTime.Now.AddDays(randGen.Next(5, nRecords + 5))
                    .AddHours(randGen.Next(0, 12)).AddMinutes(randGen.Next(0, 30));
                productionToBeCreated.Create();
                Console.WriteLine(productionToBeCreated);
            }
        }

        
    }
}
