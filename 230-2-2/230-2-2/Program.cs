namespace _230_2_2
{
    class Program
    {
        static int ageConv(int age)
        {

            if (age < 20)
            {
                return -10;
            }

            else if (age > 21 && age < 31)
            {
                return 0;
            }

            else if (age > 30 && age < 51)
            {
                return 20;
            }

            else
            {
                return 25;
            }

        }

        static int addConv(int addYears)
        {

            if (addYears < 1)
            {
                return -5;
            }

            else if (addYears > 0 && addYears < 4)
            {
                return 5;
            }

            else if (addYears > 3 && addYears < 9)
            {
                return 12;
            }

            else
            {
                return 20;
            }

        }


        static int incConv(int salary)
        {

            if (salary < 15001)
            {
                return 0;
            }

            else if (salary > 15000 && salary < 25001)
            {
                return 12;
            }

            else if (salary > 25000 && salary < 40001)
            {
                return 24;
            }

            else
            {
                return 30;
            }

        }

        static int jobConv(int jobYears)
        {

            if (jobYears < 2)
            {
                return -4;
            }

            else if (jobYears > 1 && jobYears < 5)
            {
                return 8;
            }

            else
            {
                return 15;
            }

        }

        static void Main(string[] args)
        {

            try
            {

                Console.Out.Write("Enter age                      :");
                string strAge = Console.ReadLine();
                int age = int.Parse(strAge);

                Console.Out.Write("Enter years at current address :");
                string straddYears = Console.ReadLine();
                int addYears = int.Parse(straddYears);

                Console.Out.Write("Enter Annual Income            :");
                string strInc = Console.ReadLine();
                int inc = int.Parse(strInc);

                Console.Out.Write("Enter years at current Job     :");
                string strjobYears = Console.ReadLine();
                int jobYears = int.Parse(strjobYears);

                int agePts = ageConv(age);
                int addPts = addConv(addYears);
                int incPts = incConv(inc);
                int jobPts = jobConv(jobYears);

                int total = agePts + addPts + incPts + jobPts;

                if (total < 21)
                {
                    Console.WriteLine("No card issued.");
                }

                else if (total < 36)
                {
                    Console.WriteLine("Card issues with $500 credit limit.");
                }


                else if (total < 61)
                {
                    Console.WriteLine("Card issues with $2000 credit limit.");
                }

                else
                {
                    Console.WriteLine("Card issues with $5000 credit limit.");
                }

            }

            catch (FormatException)
            {
                Console.Out.WriteLine("Please enter integers.");

            }

        }
    }
}
