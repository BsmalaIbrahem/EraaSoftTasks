using LinqProject.Data;
using LinqProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace LinqProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext context = new ApplicationDbContext();

            // 1- List all customers' first and last names along with their email addresse

            var customer = context.Customers;
            var CustomerNamesAndEmails = customer.Select(x => new {x.LastName, x.FirstName, x.Email}).ToList();

            // 2-Retrieve all orders processed by a specific staff member (e.g., staff_id = 3). 
            var order = context.Orders;
            var orderByStaffMember = order.Where(x => x.StaffId == 3).ToList();

            //3-Get all products that belong to a category named "Mountain Bikes". 
            var product = context.Products;
            var MountainBikesCategory = product.Where(x => x.Category.CategoryName == "Mountain Bikes").ToList();

            // 4--Count the total number of orders per store
            var OrderStoreCount = order.GroupBy(x => x.Store.StoreName).Select(x => new {Name = x.Key, Count = x.Count()});

            // 5-List all orders that have not been shipped yet (shipped_date is null). 
            var OrderNotShhipped = order.Where(x => x.ShippedDate == null).ToList();

            // 6- Display each customer’s full name and the number of orders they have placed. 
            var customerWithFullNAmeAndOrders = customer.Select(x => new {FullName = x.FirstName + " " + x.LastName, OrdersCount = x.Orders.Count() });

            // 7- List all products that have never been ordered (not found in order_items). 
            var ProductWithNoOrder = product.Where(x => x.OrderItems.Count() == 0).ToList();

            // 8- Display products that have a quantity of less than 5 in any store stock
            var stock = context .Stocks;
            var ProductWithQuantity = stock.Include(x => x.Product).Where(x => x.Quantity < 5).ToList();
            // another way
            var ProductWithQuantity2 = product.Include(x => x.Stocks).Where(x => x.Stocks.Any(x => x.Quantity < 5)).ToList();

            // 9-Retrieve the first product from the products table. 
            var firstProduct = product.FirstOrDefault();

            //10-Retrieve all products from the products table with a certain model year
            var ProductsInModelYear = product.Where(x => x.ModelYear == 2001).ToList();

            //11- Display each product with the number of times it was ordered
            var orderItem = context.OrderItems;

            var ProductWithOrderCout = orderItem.GroupBy(x => new { x.Product.ProductName })
                    .Select(x => new { Name = x.Key.ProductName, Count = x.Count() });
            //عن طريق الكمية
            var ProductWithOrderCout2 = orderItem.GroupBy(x => new { x.Product.ProductName})
                    .Select(x => new {Name = x.Key.ProductName, Count = x.Sum(e => e.Quantity)});

            //12-Count the number of products in a specific category
            var category = context.Categories;
            var ProductsInCategoryCount = category.Select(x => new {x.CategoryName, ProductsCount = x.Products.Count()});

            //13- Calculate the average list price of products
            var avaragePoducts = product.Average(x => x.ListPrice);

            //14-Retrieve a specific product from the products table by ID
            var productById = product.FirstOrDefault(x => x.ProductId == 5);
            var productById2 = product.SingleOrDefault(x => x.ProductId == 5);
            var productById3 = product.Find(5);

            //15-List all products that were ordered with a quantity greater than 3 in any order
            var ProductWithSpecifiedQuantity = product.Where(x => x.OrderItems.Any(e => e.Quantity > 3)).ToList();

            //16-Display each staff member’s name and how many orders they processed
            var staff = context.Staffs;
            var staffData = staff.Select(x => new {Name = x.FirstName + " " + x.LastName, OrdersCount = x.Orders.Count()});

            //17-List active staff members only (active = true) along with their phone numbers
            var activeStaff = staff.Where(x => x.Active == 1).Select(x => new { x.StaffId, x.Phone });

            //18-List all products with their brand name and category name
            var productsWithBrandAndCategory = product.Include(x => x.Category).Include(x => x.Brand).Select(x => 
                        new {
                            Category = x.Category.CategoryName,
                            Brand = x.Brand.BrandName
                        });

            //19-Retrieve orders that are completed
            var CompletedOrder = order.Where(x => x.OrderStatus == 1).ToList();

            //20-List each product with the total quantity sold (sum of quantity from order_items). 
            var ProductWithOrderSum = orderItem.GroupBy(x => new { x.Product.ProductName })
                    .Select(x => new { Name = x.Key.ProductName, Count = x.Sum(e => e.Quantity) });
        }

    }
}
