﻿namespace NimmalaWeek6.Models
{
    using System;
    using System.Collections.Generic;
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        //Navigation property
        public ICollection<Enrollment> Enrollments { get; set; }



    }
}
