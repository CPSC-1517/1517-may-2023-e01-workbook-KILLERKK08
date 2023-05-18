namespace OOPsReview
{
    public class Employement
    {
        private SupervisoryLevel _Level;
        private string _Title;
        private double _Years;

        public string Title
        {
            get { return _Title; }
            set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Title is required");
                }
                _Title = value;
            }
        }
        public SupervisoryLevel Level
        {
            get { return _Level; }
            private set
            {
                if (!Enum.IsDefined(typeof(SupervisoryLevel), value))
                {
                    throw new ArgumentException($"Supervisory level is invalid: {value}");
                }
                _Level = value;
            }
        }
        public double Years
        {
            get { return Years; }
            set
            {
                //if (value < 0)
                if (!Utilities.IsZeroOrPositive(value))
                {
                    throw new ArgumentOutOfRangeException ("value");
                }
                _Years = value;
            }
        }
        public DateTime StartDate { get; private set; }

        public Employement ()
        {
            Title = "Unknown";
            Level = SupervisoryLevel.TeamMember;
            StartDate = DateTime.Today;
        }
        public Employement(string title, SupervisoryLevel level, DateTime startdate, double years = 0.0)
        {
            Title = title;
            Level = level;
            Years = years;

            if (startdate >= DateTime.Today.AddDays(1))
            {
                throw new ArgumentException($"The start date{startdate} cannot be in future");
            }
            StartDate = startdate;
        }
        public void SetEmployemntResponsibilityLevel (SupervisoryLevel level)
        {
            Level = level;
        }
        public void CorrectStartDate (DateTime startdate)
        {
            if (startdate >= DateTime.Today.AddDays(1))
            {
                throw new ArgumentException($"The start date{startdate} cannot be in future");
            }
            StartDate = startdate;
        }

        public override string ToString()
        {
            return $"{Title},{Level},{StartDate.ToString("MMM dd, yyyy")},{Years}";
        }
        public void UpdateCurrentEmployementYearsExperience()
        {
            TimeSpan span = DateTime.Now - StartDate;
            Years = Math.Round((span.Days / 365.25), 1);
        }
    }
}