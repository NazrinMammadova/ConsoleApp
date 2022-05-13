using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp104
{
     class Student
    {
         int _Id;
        public string Name;
        public string Surname;
        public string  GroupNo;
        public string Type;

        public Student(int id,string name,string surname,string groupno,string type )
        {
            Id = id;
            Name = name;
            Surname = surname;
            GroupNo = groupno;
            Type = type;

        }

        public int Id 
        {
            get
            {
                return _Id;


            }
            set
            {
                _Id = value;

            }

        }


    }
}
