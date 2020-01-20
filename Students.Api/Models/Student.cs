using System;

namespace Students.Api.Models
{
    public class Student
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }
    }
}
