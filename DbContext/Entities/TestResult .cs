namespace Question.DbContext.Entities
{
    public class TestResult
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime TestDate { get; set; }
        public double Score { get; set; }
    }
}
