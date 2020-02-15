using System;
using System.Collections.Generic;
using System.Text;

namespace DDDWebapi.Application.DTO
{
    public class MonthlyReportDTO
    {
        public int Id { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public int AccessCount { get; set; }
        public int NewUserCount { get; set; }
    }
}
