using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data;

namespace AuntRosieEntities
{
    public class ProductItem : RosieEntity
    {
        private int id;
        private byte sizeID;
        private double price;
        private short productID;

        /// <summary>
        /// Prepared statement to retrieve product by id
        /// </summary>
        private static SqlCommand retrieveIdPrepCmd = null;

        private static SqlCommand retrieveNamePrepCmd = null;

        public Product Product
        {
            get
            {
                return Product.Retrieve(productID);
            }
            set
            {
                this.ProductID = value.Id;
                Update();
            }
        }

        public ProductSize ProductSize
        {
            get => default;
            set
            {
            }
        }

        public int Id { get => id;}
        public byte SizeID { get => sizeID; set => sizeID = value; }
        public double Price { get => price; set => price = value; }
        public short ProductID { get => productID; set => productID = value; }

        private void SetID(int id)
        {
            this.id = id;
        }

        public override void Create(SqlTransaction transaction = null)
        {
            throw new NotImplementedException();
        }

        public override void Delete(SqlTransaction transaction = null)
        {
            throw new NotImplementedException();
        }

        public override void Update(SqlTransaction transaction = null)
        {
            throw new NotImplementedException();
        }

        public static ProductItem Retrieve(int id)
        {
            ProductItem productItem = null;

            //Prepare statement
            if (retrieveIdPrepCmd is null)
            {
                retrieveIdPrepCmd = new SqlCommand(null, Connector.Connection);
                retrieveIdPrepCmd.CommandText = "select [ProductID], [SizeID], [Price] from [tblProductItem] where [ProductItemID] = @ID";


                SqlParameter idParam = new SqlParameter("@ID", SqlDbType.SmallInt, 0);
                idParam.Value = id;

                retrieveIdPrepCmd.Prepare();
            }
            else
            {
                retrieveIdPrepCmd.Parameters["ID"].Value = id;
            }

            //Process result
            SqlDataReader reader = Connector.Retrieve(retrieveIdPrepCmd);
            if (reader.HasRows)
            {
                reader.Read();
                productItem = new ProductItem();
                productItem.SetID(id);
                productItem.ProductID = reader.GetInt16(0);
                productItem.SizeID = reader.GetByte(1);
                productItem.Price = reader.GetDouble(2);
            }

            reader.Close();

            return productItem;
        }
        
        /// <summary>
        /// Get a list of all product items
        /// </summary>
        /// <param name="productionId"></param>
        /// <returns></returns>
        public static List<ProductItem> GetProductItems()
        {
            List<ProductItem> items = null;

            //Process result
            SqlDataReader reader = Connector.Retrieve("select [ProductItemID], [ProductID], [SizeID], [Price]" +
                "from [tblProductItem] where [ProductItemID] = @ID");
            while (reader.HasRows)
            {
                reader.Read();
                ProductItem productItem = new ProductItem();
                productItem.SetID(reader.GetInt32(0));
                productItem.ProductID = reader.GetInt16(1);
                productItem.SizeID = reader.GetByte(2);
                productItem.Price = reader.GetDouble(3);

                items.Add(productItem);
            }

            reader.Close();

            return items;
        }
    }
}