using System;
using System.Collections.Generic;
using System.Text;

namespace DDDWebapi.Application.DTO
{
    public class ScoreDTO
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int Level { get; set; }
        public float Time { get; set; }
        public float Value { get; set; }
    }
}
