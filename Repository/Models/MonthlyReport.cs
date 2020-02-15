namespace DDDWebapi.Domain.Models
{
    public class MonthylyReport : Base
    {
        public int Month { get; set; }
        public int Year { get; set; }
        public int AccessCount { get; set; }
        public int NewUserCount { get; set; }
    }
}
