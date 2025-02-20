
namespace ALF.AutoRepair.BL
{
    public class InvalidYearException : Exception
    {
        public int InvalidYear { get; set; }

        // constructors

        public InvalidYearException()
           : base("An invalid year was entered.") { }
        
        public InvalidYearException(int invalidYear)
            :base(invalidYear + " is an invalid year.")
        {
            InvalidYear = invalidYear;
        }
    }
}
