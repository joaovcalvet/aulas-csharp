using Course.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string h = "João Victor Calvet";
            int n = 123456;
            double s = 25.36;

            Account c = new Account(n, h, s);
            c.CheckAccount();
        }
    }
}