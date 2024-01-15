using System;
using Source.School.Subjects;

namespace Source.School.Humans {
    public class Student {
        public string Name { get; set; } = "Student";

        public Subject CountryLanguage { get; set; } = new Subject();
        public Subject Math { get; set; } = new Subject();
        public Subject English { get; set; } = new Subject();

        public Student(string name, int countryLanguagePoint, int mathPoint, int englishPoint) {
            this.Name = name;

            CountryLanguage.Name = "Country Language";
            CountryLanguage.Point = countryLanguagePoint;

            Math.Name = "Math";
            Math.Point = mathPoint;

            English.Name = "English";
            English.Point = englishPoint;
        }
    }
}
