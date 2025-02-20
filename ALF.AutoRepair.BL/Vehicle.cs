namespace ALF.AutoRepair.BL
{
    public class Vehicle
    {

        // fields
        private int year;  

        // properties
        public string Make { get; set; } = "";

        public string Model { get; set; } = "";

        public int Year
        {
            get { return year; }
            set
            {
                if (value < 1900) throw new InvalidYearException(value);
                year = value;
            }
        } 
        


        // methods
        public virtual string GetDisplay()
        {
            return Year.ToString() + " " + Make + " " + Model;
        }
    }
}
