namespace PickleBall.Domain.DTOs.TransactionDtos;

public class CurrentRevenueDto
{
    public DateTime CurrentDate { get; set; }
    public decimal TotalDayRevenue { get; set; }
    public decimal TotalMonthRevenue { get; set; }
    public int PlayerCountOfMonth { get; set; }
}
