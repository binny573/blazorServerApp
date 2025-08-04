namespace BlazorApp.Table;

using Azure;
using Azure.Data.Tables;
using Microsoft.AspNetCore.Components.Routing;

public class VehicleOfferEntity : ITableEntity
{
    public string PartitionKey { get; set; } = default!;
    public string RowKey { get; set; } = default!;
    public DateTimeOffset? Timestamp { get; set; }
    public ETag ETag { get; set; }
    public string? Vehicle { get; set; }
    public string? Company { get; set; }
    public int? Year { get; set; }
    public double? Price { get; set; }
    public string? Location { get; set; }
}