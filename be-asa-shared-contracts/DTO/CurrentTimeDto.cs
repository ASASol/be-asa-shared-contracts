namespace be_asa_shared_contracts.DTO
{
    public class CurrentTimeDto
    {
        public DateTimeOffset SystemTimeNow { get; set; }
        public string Year { get; set; }     // yyyy
        public string Date { get; set; }     // yyyyMMdd
        public string Time { get; set; }     // HH:mm
        public string MonthDay { get; set; } // MMdd
    }
}
