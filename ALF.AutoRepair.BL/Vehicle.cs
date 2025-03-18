namespace ALF.AutoRepair.BL
{
    public class Vehicle : IStartable
    {

        // fields
        private int year;  

        // properties
        public string Make { get; set; } = "";

        public string Model { get; set; } = "";
        public bool IsRunning { get; set; }


        public int Year
        {
            get { return year; }
            set
            {
                if (value < 1908) throw new InvalidYearException(value);
                year = value;
            }
        }

        // constructors
        public Vehicle() { }

        public Vehicle(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }

        // methods
        public virtual string GetDisplay()
        {
            return Year + " " + Make + " " + Model;
        }

        public override string ToString()
        {
            return GetDisplay();
        }

        public void Start()
        {
            IsRunning = true;
        }
    }
}
