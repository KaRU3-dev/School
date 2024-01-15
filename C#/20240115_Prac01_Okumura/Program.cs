using System;

namespace Core {
    public class Program {
        public static void Main(string[] args) {
            // Create school system
            var system = new Source.School.System();

            // Create students
            system.Students.StudentList.Add(new Source.School.Humans.Student("John", 60, 45, 80));
            system.Students.StudentList.Add(new Source.School.Humans.Student("Jane", 80, 90, 100));
            system.Students.StudentList.Add(new Source.School.Humans.Student("Jack", 100, 100, 100));

            // Add students to grade list
            foreach (var student in system.Students.StudentList) {
                system.GradeList.CountryLanguage.Add(student.CountryLanguage);
                system.GradeList.Math.Add(student.Math);
                system.GradeList.English.Add(student.English);
            }

            // Calculate grade average
            var gradeAverage = new Source.School.GradeSystem.GradeAverage();
            int countryLanguageAverage = gradeAverage.CalculateCountryLangAverage(system.GradeList);
            int mathAverage = gradeAverage.CalculateMathAverage(system.GradeList);
            int englishAverage = gradeAverage.CalculateEnglishAverage(system.GradeList);

            // Add grade average to grade avg list
            int[] gradeAverageList = { countryLanguageAverage, mathAverage, englishAverage };

            // LINQ query for sort grade average list in descending order
            var sortedGradeAverageList = from grade in gradeAverageList
                                         orderby grade descending
                                         select grade;

            // Print sorted grade average list
            Console.WriteLine("Sorted grade average list:");
            foreach (var grade in sortedGradeAverageList) {
                Console.WriteLine(grade);
            }
        }
    }
}
