﻿namespace ERP.Domain.Core.Entity.StudentEntity
{
    public class StudentResult
    {
        public int StudentResultId { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public double StudentScore { get; set; }

    }
}