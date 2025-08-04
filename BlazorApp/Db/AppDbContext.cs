namespace BlazorApp.Db;

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
    : base(options) { }

    public DbSet<Customer> Customers { get; set; }
}

[Table("customer")] // 👈 match the exact table name in PostgreSQL
public class Customer
{
    public int id { get; set; }
    public string? firstname { get; set; }
    public string? lastname { get; set; }
    public string? emailid { get; set; }
    public float? contactnumber { get; set; }
    public string? buildingname { get; set; }
    public string? street { get; set; }
    public string? area { get; set; }
    public float? pincode { get; set; }
    public string? city { get; set; }
}