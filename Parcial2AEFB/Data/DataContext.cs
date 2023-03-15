using System.Data.Entity;

namespace Parcial2AEFB.Data
{
    public class DataContext:DbContext
    {
        DbSet<Customer> Customers { get; set; }
        DbSet<Employee> Employees { get; set;}
        DbSet<Contact> Contacts { get; set; }
        DbSet<Inventory> Inventories { get; set; }
        DbSet<Location> Locations { get; set; }

        public DataContext():base("name=con")
        {

        }
    }
}
