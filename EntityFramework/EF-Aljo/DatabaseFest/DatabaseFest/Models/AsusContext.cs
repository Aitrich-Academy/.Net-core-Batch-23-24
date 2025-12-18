using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DatabaseFest.Models;

public partial class AsusContext : DbContext
{
    public AsusContext()
    {
    }

    public AsusContext(DbContextOptions<AsusContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Customer1> Customers1 { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Department1> Departments1 { get; set; }

    public virtual DbSet<Employe> Employes { get; set; }

    public virtual DbSet<Employe1> Employes1 { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Employee1> Employees1 { get; set; }

    public virtual DbSet<Employees1> Employees1s { get; set; }

    public virtual DbSet<Employees2> Employees2s { get; set; }

    public virtual DbSet<Employees3> Employees3s { get; set; }

    public virtual DbSet<Job> Jobs { get; set; }

    public virtual DbSet<Maneger> Manegers { get; set; }

    public virtual DbSet<Master> Masters { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<Sale> Sales { get; set; }

    public virtual DbSet<Sales1> Sales1s { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=LAPTOP-AV59POUI;Initial Catalog=ASUS;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.Customerid).HasName("PK__customer__B61ED7F54008732D");

            entity.ToTable("customer");

            entity.Property(e => e.Customerid)
                .ValueGeneratedNever()
                .HasColumnName("customerid");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Customer1>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PK__Customer__A4AE64D854FF05B7");

            entity.ToTable("CustomerS");

            entity.Property(e => e.CustomerId).ValueGeneratedNever();
            entity.Property(e => e.Email).HasMaxLength(150);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.Username).HasMaxLength(50);
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Department");

            entity.Property(e => e.Departmentname).HasMaxLength(50);
        });

        modelBuilder.Entity<Department1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Departments");

            entity.Property(e => e.DeptId).HasColumnName("DeptID");
            entity.Property(e => e.DeptName).HasMaxLength(50);
        });

        modelBuilder.Entity<Employe>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Employe");

            entity.Property(e => e.EmpId).HasColumnName("EmpID");
            entity.Property(e => e.EmpName).HasMaxLength(50);
            entity.Property(e => e.ManagerId).HasColumnName("ManagerID");
        });

        modelBuilder.Entity<Employe1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("employes");

            entity.Property(e => e.Employeeid).HasColumnName("employeeid");
            entity.Property(e => e.Manegerid).HasColumnName("manegerid");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Employeeid).HasName("PK__employee__C135F5E957B7717F");

            entity.ToTable("employee");

            entity.Property(e => e.Employeeid)
                .ValueGeneratedNever()
                .HasColumnName("employeeid");
            entity.Property(e => e.Department)
                .HasMaxLength(50)
                .HasColumnName("department");
            entity.Property(e => e.Salary)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("salary");
        });

        modelBuilder.Entity<Employee1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Employees");

            entity.Property(e => e.EmpId).HasColumnName("EmpID");
            entity.Property(e => e.EmpName).HasMaxLength(50);
        });

        modelBuilder.Entity<Employees1>(entity =>
        {
            entity.HasKey(e => e.EmployeeId).HasName("PK__Employee__7AD04FF1EB45DD73");

            entity.ToTable("Employees1");

            entity.Property(e => e.EmployeeId)
                .ValueGeneratedNever()
                .HasColumnName("EmployeeID");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.JobTitle).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Employees2>(entity =>
        {
            entity.HasKey(e => e.EmployeeId).HasName("PK__Employee__7AD04FF122C5DE15");

            entity.ToTable("Employees2");

            entity.Property(e => e.EmployeeId)
                .ValueGeneratedNever()
                .HasColumnName("EmployeeID");
            entity.Property(e => e.JobTitle).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Employees3>(entity =>
        {
            entity.HasKey(e => e.EmployeeId).HasName("PK__Employee__7AD04FF167F0496E");

            entity.ToTable("Employees3");

            entity.Property(e => e.EmployeeId)
                .ValueGeneratedNever()
                .HasColumnName("EmployeeID");
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.JobTitle).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Job>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("job");

            entity.Property(e => e.Employeeid).HasColumnName("employeeid");
            entity.Property(e => e.Jobtitle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("jobtitle");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Maneger>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("manegers");

            entity.Property(e => e.Departmentid).HasColumnName("departmentid");
            entity.Property(e => e.Employeeid).HasColumnName("employeeid");
            entity.Property(e => e.Manegerid).HasColumnName("manegerid");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Master>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Mastername).HasMaxLength(50);
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.Customerid).HasName("PK__orders__B61ED7F5A579D276");

            entity.ToTable("orders");

            entity.Property(e => e.Customerid)
                .ValueGeneratedNever()
                .HasColumnName("customerid");
            entity.Property(e => e.Amount).HasColumnName("amount");
            entity.Property(e => e.Orderid).HasColumnName("orderid");
        });

        modelBuilder.Entity<Sale>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PK__SALES__B40CC6CD41D20474");

            entity.ToTable("SALES");

            entity.Property(e => e.Amount).HasColumnName("amount");
            entity.Property(e => e.Product)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Region)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Sales1>(entity =>
        {
            entity.HasKey(e => e.SaleId).HasName("PK__Sales1__1EE3C41FE784F47A");

            entity.ToTable("Sales1");

            entity.Property(e => e.SaleId)
                .ValueGeneratedNever()
                .HasColumnName("SaleID");
            entity.Property(e => e.Category)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PricePerUnit).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.ProductName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
