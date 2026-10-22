using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace miniProject.ciewModel
{
    public class Teacher
    {
        [Key]
        public int teacherId {get; set;}
        public string name {get; set;}
        public int age {get; set;}

        public Teacher(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void showStats()
        {
            System.Console.WriteLine($"Имя: {name}, возраст: {age}");
        }
    }
}