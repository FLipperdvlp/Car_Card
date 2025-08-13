namespace MVC_Cars_Cards.Entities;

public class Car
{
    public Guid Id { get; set; }
    
    public string? Company { get; set; }
    public string? Model { get; set; }
    
    public int Year { get; set; }
    public int Mileage { get; set; }
    
    public decimal Price { get; set; }
    
    public bool WasInAccident { get; set; }
}