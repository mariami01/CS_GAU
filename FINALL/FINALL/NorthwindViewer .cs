using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINALL
{
  class NorthwindViewer
  {
    NortwindDataContext northwind;

    public NorthwindViewer()
    {
      northwind = new NortwindDataContext();
      northwind.Log = Console.Out;
    }

    [RunnableMethod]
    public void NumberOfCustomers()
    {
      Console.WriteLine(northwind.Customers.Count());
    }

    [RunnableMethod]
    public void NumberOfCustomersPerCountry()
    {
      var numbersPerCountries =
          from customer in northwind.Customers
          group customer by customer.Country into g
          orderby g.Count() descending
          select new { Country = g.Key, Count = g.Count() };

      foreach (var nc in numbersPerCountries)
      {
        Console.WriteLine("{0}: {1} customer(s)", nc.Country, nc.Count);
      }
    }

    [RunnableMethod]
    public void CustomersFromItaly()
    {
      var Italians = northwind.Customers.Where(c => c.Country == "Italy");

      foreach (var italian in Italians)
      {
        Console.WriteLine("{0,-30} {1,-10} {2,-20}",
            italian.CompanyName, italian.Country, italian.City);
      }
    }

    [RunnableMethod]
    public void ProductsAvailability()
    {
      var products =
          from p in northwind.Products
          select new
          {
            p.ProductName,
            Availability = p.UnitsInStock - p.UnitsOnOrder < 0 ? "Out Of Stock" : "In Stock"
          };

      foreach (var p in products)
      {
        Console.WriteLine("{0}: {1}", p.ProductName, p.Availability);
      }
    }

    [RunnableMethod]
    public void DiscountedProducts()
    {
      var orders =
          from o in northwind.Orders
          select new
          {
            o.OrderID,
            DiscountedProducts =
                  from od in o.Order_Details
                  where od.Discount > 0.0
                  select new { OrderDetails = od, od.Product.ProductName }
          };

      foreach (var order in orders)
      {
        Console.WriteLine("order ID: {0}", order.OrderID);
        foreach (var od in order.DiscountedProducts)
        {
          Console.WriteLine("    product ID: {0}, name: {1}, discount: {2}",
              od.OrderDetails.ProductID, od.ProductName, od.OrderDetails.Discount);
        }
      }
    }

    [RunnableMethod]
    public void TotalFreight()
    {
      //var totalFreight = northwind.Orders.Select(o => o.Freight).Sum();
      var totalFreight = northwind.Orders.Sum(o => o.Freight);

      Console.WriteLine("Total freight: {0}", totalFreight);
    }

    [RunnableMethod]
    public void MostExpensiveProductsPerCategory()
    {
      var categories =
          from p in northwind.Products
          group p by p.CategoryID into g
          join c in northwind.Categories on g.Key equals c.CategoryID
          select new
          {
            CategoryID = g.Key,
            CategoryName = c.CategoryName,
            MostExpensiveProducts =
                  from p2 in g
                  where p2.UnitPrice == g.Max(p3 => p3.UnitPrice)
                  select p2
          };

      foreach (var category in categories)
      {
        Console.WriteLine("Category ID: {0}, name: {1}",
            category.CategoryID, category.CategoryName);
        foreach (var product in category.MostExpensiveProducts)
        {
          Console.WriteLine("    Product ID: {0}, name: {1}, unit price: {2}",
              product.ProductID, product.ProductName, product.UnitPrice);
        }
      }
    }

    [RunnableMethod]
    public void NumberOfOrdersPerCustomer()
    {
      var qq =
          from order in northwind.Orders
          group order by order.CustomerID into orders
          join customer in northwind.Customers on orders.Key equals customer.CustomerID
          select new
          {
            CustomerID = orders.Key,
            CompanyName = customer.CompanyName,
            Count = orders.Count()
          };

      foreach (var q in qq)
      {
        Console.WriteLine("Customer ID: {0}, company name: {1}, number of orders: {2}",
            q.CustomerID, q.CompanyName, q.Count);
      }
    }

    [RunnableMethod]
    public void NumberOfOrdersPerCustomer_Alt()
    {
      var qq =
          from customer in northwind.Customers
          select new
          {
            CustomerID = customer.CustomerID,
            CompanyName = customer.CompanyName,
            Count = northwind.Orders.Where(o => o.CustomerID == customer.CustomerID).Count()
          };

      foreach (var q in qq)
      {
        Console.WriteLine("Customer ID: {0}, company name: {1}, number of orders: {2}",
            q.CustomerID, q.CompanyName, q.Count);
      }
    }

    [RunnableMethod]
    public void CustomersWithoutOrders()
    {
      var customers =
          from c in northwind.Customers
          where !c.Orders.Any()
          select c;

      foreach (var customer in customers)
      {
        Console.WriteLine(customer.CustomerID);
      }
    }

    

    [RunnableMethod]
    public void InsertNewCustomer()
    {
      Console.WriteLine("Before: {0}", northwind.Customers.Count());

      var newCustomer = new Customer
      {
        CustomerID = "MCSFT",
        CompanyName = "Microsoft",
        ContactName = "John Doe",
        ContactTitle = "Sales Manager",
        Address = "1 Microsoft Way",
        City = "Redmond",
        Region = "WA",
        PostalCode = "98052",
        Country = "USA",
        Phone = "(425) 555-1234",
        Fax = null
      };
      northwind.Customers.InsertOnSubmit(newCustomer);
      northwind.SubmitChanges();

      Console.WriteLine("After: {0}", northwind.Customers.Count());
    }

    [RunnableMethod]
    public void DeleteCustomer()
    {
      Console.WriteLine("Before: {0}", northwind.Customers.Count());

      northwind.Customers.DeleteAllOnSubmit(
          northwind.Customers.Where(c => c.CustomerID == "MCSFT"));
      northwind.SubmitChanges();

      Console.WriteLine("After: {0}", northwind.Customers.Count());
    }

    [RunnableMethod]
    public void ModifyCustomer()
    {
      Console.WriteLine("[1]: {0}", northwind.Customers.First().ContactTitle);

      string old = northwind.Customers.First().ContactTitle;
      northwind.Customers.First().ContactTitle = "-- modified --";
      northwind.SubmitChanges();

      northwind.Customers.First().ContactTitle = "-- modified (2) --";
      Console.WriteLine("[2]: {0}", northwind.Customers.First().ContactTitle);

      // clear the cache by recreating the DataContext object
      northwind = new NortwindDataContext() { Log = northwind.Log };
      Console.WriteLine("[3]: {0}", northwind.Customers.First().ContactTitle);

      northwind.Customers.First().ContactTitle = old;
      northwind.SubmitChanges();

      Console.WriteLine("[4]: {0}", northwind.Customers.First().ContactTitle);
    }
  }
}
