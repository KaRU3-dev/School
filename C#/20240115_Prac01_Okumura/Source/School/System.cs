using System;

using Source.School.GradeSystem;

namespace Source.School {
    public class System {
        // Create students
        public Students Students { get; set; } = new Students();

        // Create grade list
        public GradeList GradeList { get; set; } = new GradeList();

    }
}
