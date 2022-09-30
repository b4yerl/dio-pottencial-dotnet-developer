using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroCSharpII.Models
{
    public class Course
    {
        public string Name {get; set;}
        public List<Person> AllStudents {get; set;}

        public void AddStudent(Person student) {
            AllStudents.Add(student);
        }
        public bool RemoveStudent(Person student) {
            return AllStudents.Remove(student);
        }
        public void ListStudents() {
            Console.WriteLine($"Os alunos matriculados neste curso de {Name} são:");
            
            for(int i = 0; i < AllStudents.Count; i++) {
                //string parteNova = "Nº " + (i + 1) + " - " + AllStudents[i].FullName;
                string parteNova = $"Nº {i + 1} - {AllStudents[i].FullName}";
                Console.WriteLine(parteNova);
            }
        }
        public int CountStudents() => AllStudents.Count;
    }
}