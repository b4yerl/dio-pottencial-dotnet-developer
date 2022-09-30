using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroCSharpII.Models
{
    public class Person
    {
        public Person(){

        }
        public Person(string name, string lastname){
            Name = name;
            LastName = lastname;
        }
        public void Deconstruct(out string name, out string lastName) {
            name = Name;
            lastName = LastName;
        }

        private string _name;
        private string _lastname;
        private int _age;
        
        public string Name {
            get =>_name.ToUpper();
        
            set {
                if(value == "") {
                    throw new ArgumentException("O nome não pode ser vazio");
                }

                _name = value;
            }
        }      
        public string LastName {
             get =>_lastname.ToUpper();
        
            set {
                if(value == "") {
                    throw new ArgumentException("O nome não pode ser vazio");
                }

                _lastname = value;
            }
        }
        public string FullName => $"{_name} {_lastname}".ToUpper();
        public int Age {
            get => _age;
            
            set {
                if(value < 0) {
                    throw new ArgumentException("A idade não pode ser negativa");
                }

                _age = value;
            }
        }

        public void PresentYourself(){
            Console.WriteLine($"Nome: {_name}, Idade: {Age}");
        }
    }
}