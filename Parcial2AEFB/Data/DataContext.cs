using System.Data.Entity;

namespace Parcial2AEFB.Data
{
    public class DataContext:DbContext
    {
        DbSet<Employee> Employees { get; set;}

        public DataContext():base("name=con")
        {

        }
    }
}
