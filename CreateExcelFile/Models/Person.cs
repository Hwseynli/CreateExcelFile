﻿namespace CreateExcelFile.Models
{
    public class Person
    {
        public int ID { get; set; }
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string FatherName { get; set; } = "";
        public DateTime Birthday { get; set; }
    }
}