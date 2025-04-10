namespace Assignments;

class Library
{
    enum AccountState
    {
        Standard = 1,
        Gold = 5,
        Premium = 10,
    }

    class Account(string firstName, string lastName, DateTime dateOfBirth)
    {
        private static int count;
        private string firstName = firstName;
        private string lastName = lastName;
        private DateTime dateOfBirth = dateOfBirth;
        private static readonly decimal minSum;

        static Account()
        {
            minSum = 1000;
            count = 0;
        }

        static decimal GetSum(decimal sum, AccountState state, int period) =>
            period * (sum >= minSum ? sum * ((int)state + 100) / 100 : sum);

        public string GetReport() => $"{firstName} {lastName} {dateOfBirth:dd/MM/yyyy}";
    }
}
