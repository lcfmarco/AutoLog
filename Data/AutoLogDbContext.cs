// Build bridge between .NET and postgreSQL DB
// Make tables, columns for tables here


using Microsoft.EntityFrameworkCore;
using AutoLog.Models;

namespace AutoLog.Data;

public class AutoLogDbContext :  DbContext // Inherit base DbContext class
{
    public AutoLogDbContext(DbContextOptions<AutoLogDbContext> options) : base(options) { }

    public DbSet<Car> Cars => Set<Car>();

    public DbSet<MaintenanceLog> MaintenanceLogs => Set<MaintenanceLog>();

}