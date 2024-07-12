namespace Course.Entities
{
    class Client
    {
        public string Name;
        public string Email;
        public DateTime BirthDate;

        public Client(string name, string email, DateTime bDate)
        {
            Name = name;
            Email = email;
            BirthDate = bDate;
        }

        public override string ToString()
        {
            return $"{Name} ({BirthDate.Date.ToShortDateString()}) - {Email}";
        }
    }
}