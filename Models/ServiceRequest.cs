namespace Majorkey.Models;

public class ServiceRequest
{
    public Guid Id { get; set; }
    public string? buildingCode { get; set; }
    public string? description { get; set; }
    public CurrentStatus currentStatus { get; set; }
    public string? createdBy { get; set; }
    public DateTime createdDate { get; set; }
    public string? lastModifiedBy { get; set; }
    public DateTime lastModifiedDate { get; set; }
}