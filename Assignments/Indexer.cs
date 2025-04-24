using System;

namespace IndexerDemo
{
    public class Grade
    {
        public string Subject { get; set; }
        public int Score { get; set; }

        public Grade(string subject, int score)
        {
            Subject = subject;
            Score = score;
        }
    }

    public class Student
    {
        private Grade[] grades = new Grade[5];

        public Grade this[int index]
        {
            get => grades[index];
            set => grades[index] = value;
        }
    }

    public class Bookshelf
    {
        private string[,] books;

        public Bookshelf(int shelves, int positions)
        {
            books = new string[shelves, positions];
        }

        public string this[int shelf, int position]
        {
            get => books[shelf, position] ?? "Empty Slot";
            set => books[shelf, position] = value;
        }
    }

    public class IndexerTests
    {
        public static void Run()
        {
            Console.WriteLine("--- Student Test ---");
            Student student = new Student();
            student[0] = new Grade("Math", 95);
            student[1] = new Grade("Physics", 88);

            Console.WriteLine($"{student[0].Subject}, Grade: {student[0].Score}");
            Console.WriteLine($"{student[1].Subject}, Grade: {student[1].Score}");

            Console.WriteLine("\n--- Bookshelf Test ---");
            Bookshelf bookshelf = new Bookshelf(2, 2);
            bookshelf[0, 0] = "Clean Code";
            bookshelf[0, 1] = "Design Patterns";
            bookshelf[1, 0] = "System Design";

            Console.WriteLine(bookshelf[0, 0]);
            Console.WriteLine(bookshelf[0, 1]);
            Console.WriteLine(bookshelf[1, 0]);
            Console.WriteLine(bookshelf[1, 1]); // Should print "Empty Slot"
        }
    }
}
