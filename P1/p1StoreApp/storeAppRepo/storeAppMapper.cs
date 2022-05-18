using System.Data.SqlClient;
using storeAppModel;
namespace storeAppRepo
{
    public class storeAppMapper
    {
         //create a method that will transfer the date from the customer list return into customers
        public Customer DboToCustomer(SqlDataReader read)
        {
            Customer c = new Customer
            {
                CustomerId = (int) read[0],
                FirstName = (string) read[1],
                LastName = (string) read[2],
                Address = (string) read[3],
                Email = (string) read[4],
                Password = (string) read[5],    
            };
            return c;
       }
       public Inventory DboToInventory(SqlDataReader read)
        {
            Inventory I = new Inventory
            {
                InventoryId = (int) read[0],
                Dictionary<Product> = (int) read[1],
                Store = (Store) read[2],
                Quantity = (int) read [3],
        
            };
            return I;
        }
        public Orders DboToOrders(SqlDataReader read)
        {
            Orders or = new Orders
            {
                LineItemId = (int) read[0],
                OrdersId = (Guid) read[1],
                Customer = (Customer) read[2],
                Dictionary = (Product) read[3],
                Store = (Store) read[4],
                Price = (decimal) read[5],   
            };
            return or;
        }

        public Product DboToProduct(SqlDataReader read)
        {
            Product p = new Product
            {
                ProductId = (int) read[0],
                ProductName = (string) read[1],
                Description = (string) read[2],
                Price = (Decimal) read[3], 
                Quantity = (int) read[4], 
            };
            return p;
        }

        public Store DboToStore(SqlDataReader read)
        {
            Store s = new Store
            {
                StoreId = (int) read[1],
                Name = (string) read[2],
                Location = (string) read[3],    
            };
            return s;
        }

}//EOC
}//EON

