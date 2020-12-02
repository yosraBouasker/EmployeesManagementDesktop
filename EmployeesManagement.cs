using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;

namespace EmployeesManagementDesktop
{
    public class EmployeesManagement : DbContext
    {
        // Your context has been configured to use a 'EmployeesManagement' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'EmployeesManagementDesktop.EmployeesManagement' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'EmployeesManagement' 
        // connection string in the application configuration file.
        public EmployeesManagement()
            : base("EmployeesManagement")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Employee> Employees { get; set; }
    }

    public class Employee
    {
        [Key]
        [Required]
        public int Employee_Id { get; set; }
        [Required]
        public string Employee_Name { get; set; }
    }
}