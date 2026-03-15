using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Numerics;
using Task_11.Data;
using Task_11.Models;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext _context = new ApplicationDbContext();
            //1-List all customers' first and last names along with their email addresses.

            //var Customer = _context.Customers.AsQueryable();

            //foreach (var item in Customer)
            //{
            //    Console.WriteLine($"{ item.FirstName + " " +  item.LastName} , {item.Email}");
            //}


            //2 - Retrieve all orders processed by a specific staff member(e.g., staff_id = 3).
            //var Orders = _context.Orders.Where(o => o.StaffId == 3).ToList();
            //foreach (var item in Orders)
            //{
            //    Console.WriteLine(item.OrderId);
            //}


            //3- Get all products that belong to a category named "Mountain Bikes".
            //var Products = _context.Products.Where(p => p.Category.CategoryName == "Mountain Bikes").ToList();
            //foreach (var item in Products)
            //{
            //    Console.WriteLine(item.ProductName);
            //}


            //4-Count the total number of orders per store.
            //var OrdersPerStore = _context.Orders.GroupBy(o => o.StoreId).Select(g => new
            //{
            //  g.Key,
            //    Count = g.Count()
            //});
            //foreach (var item in OrdersPerStore)
            //{
            //    Console.WriteLine(item.Key);
            //}


            //5 - List all orders that have not been shipped yet(shipped_date is null).
            //var orders = _context.Orders.Where(o => o.ShippedDate == null);
            //foreach (var item in orders)
            //{
            //    Console.WriteLine(item.OrderId);
            //}


            //6 - Display each customer’s full name and the number of orders they have placed
            //var CustomersWithOrdeers = _context.Customers.Include(c => c.Orders)
            //    .Select(c => new
            //    {
            //        CustomerName = c.FirstName + " " + c.LastName,
            //        orderCount = c.Orders.Count()
            //    })
            //    .ToList();
            //foreach( var item in CustomersWithOrdeers )
            //{
            //    Console.WriteLine($"{item.CustomerName} , {item.orderCount}");
            //}


            //7 - List all products that have never been ordered(not found in order_items)
            //var ProductsNeverOrdered = _context.Products.Where(p => !p.OrderItems.Any());
            //foreach (var item in ProductsNeverOrdered)
            //{
            //    Console.WriteLine(item.ProductName);
            //}


            //8 - Display products that have a quantity of less than 5 in any store stock.
            //var ProductsLess5 = _context.Stocks.Where(s => s.Quantity < 5)
            //    .Select(s => new
            //    {
            //        StoreId = s.StoreId,
            //        ProductName = s.Product.ProductName,
            //        Quantity = s.Quantity,
            //    })
            //    .ToList();
            //foreach (var item in ProductsLess5)
            //{
            //    Console.WriteLine($"{item.ProductName} , {item.StoreId} , {item.Quantity}");
            //}


            //9 - Retrieve the first product from the products table.
            //var Products = _context.Products.FirstOrDefault();
            //Console.WriteLine(Products.ProductName);


            //10- Retrieve all products from the products table with a certain model year.
            //var Products = _context.Products.ToList();
            //foreach (var item in Products)
            //{
            //    Console.WriteLine($"{item.ProductName} , {item.ModelYear}");
            //}


            //11 - Display each product with the number of times it was ordered.
            //var ProductOrderCount = _context.Products.Select(p => new
            //{
            //    ProductName=p.ProductName,
            //    OrdersCount = p.OrderItems.Count(),
            //})
            //    .ToList();
            //foreach (var item in ProductOrderCount)
            //{
            //    Console.WriteLine($"{item.ProductName} , {item.OrdersCount}");
            //}


            //12- Count the number of products in a specific category.
            //var CountOfProduct = _context.Products.GroupBy(p => p.Category.CategoryName).Select(g => new
            //{
            //    g.Key,
            //    count = g.Count()
            //})
            //    .ToList();
            //foreach (var item in CountOfProduct)
            //{
            //    Console.WriteLine($"{item.Key} , {item.count}");
            //}


            //13- Calculate the average list price of products.
            //var Avrageprice = _context.Products.Select(p => p.ListPrice).Average();
            //Console.WriteLine($"Avrage Price : {Avrageprice}");


            //14 - Retrieve a specific product from the products table by ID.
            //var Product = _context.Products.FirstOrDefault(p => p.ProductId == 14);

            // if (Product != null)
            // {
            //     Console.WriteLine($"{Product.ProductName} , {Product.ListPrice}");
            // }
            // else
            // {
            //     Console.WriteLine("Product is Not Founded");
            // }


            //15 - List all products that were ordered with a quantity greater than 3 in any order.
            //var Product = _context.Products.Where(p => p.OrderItems.Count() > 3)
            //    .Select(p => new
            //{
            //    ProductName = p.ProductName,
            //    OrdersCount = p.OrderItems.Count()
            //})
            //    .ToList();
            //foreach (var item in Product)
            //{
            //    Console.WriteLine($"{item.ProductName} , {item.OrdersCount} Times");
            //}


            //16 - Display each staff member’s name and how many orders they processed.

            //    var Staffs = _context.Staffs.Select(s => new
            //    {
            //        StaffF_Name = s.FirstName + " " + s.LastName,
            //        s.Orders.Count,
            //    }
            //    )
            //        .ToList();

            //foreach (var item in Staffs)
            //{
            //    Console.WriteLine($"{item.StaffF_Name} , {item.Count}");
            //}


            //17- List active staff members only (active = true) along with their phone numbers.
            //var Staffs = _context.Staffs.Where(s => s.Active == 1)
            //    .Select(s => new
            //    {
            //        StaffName = s.FirstName + " " + s.LastName,
            //        s.Phone
            //    })
            //    .ToList();

            //foreach (var item in Staffs)
            //{
            //    Console.WriteLine($"{item.StaffName} , {item.Phone}");
            //}


            //18- List all products with their brand name and category name.
            //var Products = _context.Products.Select(p => new
            //{
            //    p.ProductName,
            //    p.Category.CategoryName ,
            //    p.Brand.BrandName
            //})
            //    .ToList();
            //foreach (var item in Products)
            //{
            //    Console.WriteLine($"{item.ProductName} , {item.BrandName} , {item.CategoryName}");


            //19 - Retrieve orders that are completed.
            //var Orders = _context.Orders.Where(o => o.OrderStatus == 4)
            //    .ToList();

            //foreach (var orders in Orders)
            //{
            //    Console.WriteLine($"{orders.OrderId} , {orders.CustomerId} , {orders.OrderStatus}");
            //}


            //20 - List each product with the total quantity sold(sum of quantity from order_items).
            //var Products = _context.Products.Select(p => new
            //{
            //    p.ProductName,
            //    T = p.OrderItems.Sum(oi => (int?)oi.Quantity) ?? 0,
            //})
            //    .ToList();
            //foreach (var item in Products)
            //{
            //    Console.WriteLine($"{item.ProductName} , {item.T}");
            //}
        }

    }
}
