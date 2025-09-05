namespace AutoLog.Models;

public class MaintenanceLog
{
    public int Id { get; set; }
    public int CarId { get; set; }
    public Car? Car { get; set; }

    public string MaintenanceTitle { get; set; } = "";
    
    public string? Notes  { get; set; }
    
    public decimal? Cost { get; set; }
    
    public int Odometer { get; set; }
    
    public DateTime Date { get; set; }
    
    
}
