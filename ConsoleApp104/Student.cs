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
        public int  GroupNo;
        public string Type;
       
        public bool Guaranty;

        public Student(int id,string name,string surname,string type,int groupno,bool guaranty  )
        {
            Id = id;
            Name = name;
            Surname = surname;
            GroupNo = groupno;
            Type = type;
            Guaranty = guaranty;


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
