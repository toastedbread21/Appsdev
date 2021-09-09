using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student;
            

            Console.WriteLine("Input StudentID number : ");
            student.idnum = int.Parse(Console.ReadLine());
            Console.WriteLine("Input First name:");
            student.fname = (Console.ReadLine());
            Console.WriteLine("Input Last name :");
            student.lname = (Console.ReadLine());
            Console.WriteLine("Input Quiz score:");
            student.score = int.Parse(Console.ReadLine());
            student.score2 = 0;

            if (student.score<70) 
            {
                student.score2 = 1;
            }
            else if(student.score<80)
            {
                student.score2 = 2;
            }
            else if(student.score<90)   
            {
                student.score2 = 3;
            }
            else if (student.score <=100)
            {
                student.score2 = 4;
            }

            Console.WriteLine("Student Information:\nStudent ID: {0}\nFirst Name: {1}\nLast Name: {2}\nQuiz Score: {3}", student.idnum, student.fname, student.lname, student.score);
            switch (student.score2)
            {
                case 1:
                    Console.WriteLine("Remark: {0}", remark.Poor);
                    break;
                case 2:
                    Console.WriteLine("Remark: {0}", remark.Fair);
                    break;
                case 3:
                    Console.WriteLine("Remark: {0}", remark.Good);
                    break;
                case 4:
                    Console.WriteLine("Remark: {0}", remark.Excellent);
                    break;

            }

            Console.ReadKey();

        }
    }
    enum remark { Poor, Fair, Good, Excellent }

    public struct Student
    {
        public int idnum;
        public int score;
        public int score2;
        public string fname;
        public string lname;
    }



}