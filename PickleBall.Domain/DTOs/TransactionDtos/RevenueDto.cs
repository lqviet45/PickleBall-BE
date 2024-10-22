namespace PickleBall.Domain.DTOs.TransactionDtos;

public class RevenueDto
{
    public required string Week { get; set; }
    public decimal TotalRevenue { get; set; }
    public int PlayerCount { get; set; }
}

public class RevenueResponseDto
{
    public IEnumerable<RevenueDto> Weeks { get; set; } = [];
}

public class RevenueByOwnerIdDto
{
    public string? Week { get; set; }
    public decimal TotalRevenue { get; set; }
    public int TotalBookings { get; set; }
}

public class RevenueByOwnerIdResponseDto
{
    public List<RevenueByOwnerIdDto> Weeks { get; set; } = [];
    
    public decimal TotalRevenue { get; set; }
    
    public int TotalBookings { get; set; }
}

public class RevenueByAllOwnerDto
{
    public string? Week { get; set; }
    public decimal TotalRevenue { get; set; }
    public int TotalBookings { get; set; }
}

public class RevenueByAllOwnerResponseDto
{
    public List<RevenueByAllOwnerDto> Weeks { get; set; } = [];
    
    public decimal TotalRevenue { get; set; }
    
    public int TotalBookings { get; set; }
}

public class RevenueByAllOwnerTodayResponseDto
{
    public decimal TodayRevenue { get; set; }
    
    public int TodayBookings { get; set; }
}