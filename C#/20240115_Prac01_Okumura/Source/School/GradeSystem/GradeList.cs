using System;

using Source.School.Subjects;

namespace Source.School.GradeSystem {
    public class GradeList {
        public List<Subject> CountryLanguage { get; set; } = new List<Subject>();
        public List<Subject> Math { get; set; } = new List<Subject>();
        public List<Subject> English { get; set; } = new List<Subject>();
    }
}
