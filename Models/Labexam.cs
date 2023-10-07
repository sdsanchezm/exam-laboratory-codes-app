namespace exam_laboratory_codes_app.Models
{
    public class Labexam
    {
        public Guid ExamId { get; set; }
        public string ExamNumber { get; set; } = "N00";
        public string ExamName { get; set; } = "";
        public string CommonName { get; set; } = "";
        public bool FastingRequired { get; set; } = false;
        public string PreparationDescription { get; set; } = "";
        public string ObservationForLaboratory { get; set; } = "";
        public string ExamPlace { get; set; } = "";
        public string Schedule { get; set; } = "";
        public string ExamCode { get; set; } = "";
        public string CupsCode { get; set; } = "";
        public string SampleDescription { get; set; } = "";
        public string SampleStability { get; set; } = "";
        public string ClinicUtility { get; set; } = "";
        public string MountingDays { get; set; } = "";
        public string TimeResults { get; set; } = "";
        public string SampleTechnic { get; set; } = "";
        public string ProcessingPlace { get; set; } = "";

    }
}
