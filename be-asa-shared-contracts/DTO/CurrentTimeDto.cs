namespace be_asa_shared_contracts.DTO
{
    public class CurrentTimeDto
    {
        public DateTimeOffset UtcTime { get; set; }
        public string Year { get; set; }     // yyyy   => UTC
        public string Date { get; set; }     // yyyyMMdd  => UTC
        public string Time { get; set; }     // HH:mm  => UTC
        public string MonthDay { get; set; } // MMdd   => UTC

        public string LocalYear { get; set; }     // yyyy
        public string LocalDate { get; set; }     // yyyyMMdd
        public string LocalTime { get; set; }     // HH:mm
        public string LocalMonthDay { get; set; } // MMd
    }
}
