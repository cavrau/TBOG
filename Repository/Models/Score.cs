namespace DDDWebapi.Domain.Models
{
    public class Score : Base
    {
        public User User { get; set; }
        public int Level { get; set; }
        public float Time { get; set; }
        public float Value { get; set; }
    }
}
