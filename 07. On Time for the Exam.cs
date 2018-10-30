using System;
namespace _07.On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int timeExamHours = int.Parse(Console.ReadLine());
            int timeExamMinutes = int.Parse(Console.ReadLine());
            int timeStudentArriveHours = int.Parse(Console.ReadLine());
            int timeStudentArriveMinutes = int.Parse(Console.ReadLine());

            int timeOfExamInMinutes = (timeExamHours * 60) + timeExamMinutes;
            int timeOfStudentsInMinutes = (timeStudentArriveHours * 60) + timeStudentArriveMinutes;

            int timeDifferenceOnTime = timeOfExamInMinutes - timeOfStudentsInMinutes;
            int timeDifferenceOffTime = timeOfStudentsInMinutes - timeOfExamInMinutes;

            int printOnTimeHours = timeDifferenceOnTime / 60;
            int printOnTimeMinutes = timeDifferenceOnTime % 60;
            int printOffTimeHours = timeDifferenceOffTime / 60;
            int printOffTimeMinutes = timeDifferenceOffTime % 60;
            
            if (timeDifferenceOnTime == 0)
            {
                Console.WriteLine("On time");
            }
            else if (timeDifferenceOnTime >= 1 && timeDifferenceOnTime <= 30)
            {
                Console.WriteLine("On time");
                Console.WriteLine($"{timeDifferenceOnTime} minutes before the start");

            }
            else if (timeDifferenceOnTime > 30 && timeDifferenceOnTime <= 59)
            {
                Console.WriteLine("Early");
                Console.WriteLine($"{printOnTimeMinutes:d2} minutes before the start");
            }
            else if (timeDifferenceOnTime >= 60)
            {
                Console.WriteLine("Early");
                Console.WriteLine($"{printOnTimeHours}:{printOnTimeMinutes:d2} hours before the start");
            }
            else if (timeDifferenceOffTime <= 59)
            {
                Console.WriteLine("Late");
                Console.WriteLine($"{printOffTimeMinutes} minutes after the start");
            }
            else if (timeDifferenceOffTime >= 60)
            {
                Console.WriteLine("Late");
                Console.WriteLine($"{printOffTimeHours}:{printOffTimeMinutes:d2} hours after the start");
            }
        }
    }
}

