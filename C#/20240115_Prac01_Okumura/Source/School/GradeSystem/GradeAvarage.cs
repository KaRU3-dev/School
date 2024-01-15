using System;

namespace Source.School.GradeSystem {

    public class GradeAverage {

        public int CalculateCountryLangAverage(GradeList gradeList) {

            // Calculate average for Math
            var mathAverage = 0;
            foreach (var grade in gradeList.Math) {
                mathAverage += grade.Point;
            }
            mathAverage /= gradeList.Math.Count;

            return mathAverage;

        }

        public int CalculateMathAverage(GradeList gradeList) {

            // Calculate average for Math
            var mathAverage = 0;
            foreach (var grade in gradeList.Math) {
                mathAverage += grade.Point;
            }
            mathAverage /= gradeList.Math.Count;

            return mathAverage;

        }

        public int CalculateEnglishAverage(GradeList gradeList) {

            // Calculate average for English
            var englishAverage = 0;
            foreach (var grade in gradeList.English) {
                englishAverage += grade.Point;
            }
            englishAverage /= gradeList.English.Count;

            return englishAverage;

        }
    }
}
