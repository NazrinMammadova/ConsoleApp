using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp104
{
     class Group
    {
       
        public int No;
        Categories categorie;
        public bool IsOnline;
        public int limit;
        public List<Student> students = new List<Student>();
        public string name;
        public string no;
        
        public Group(int no,Categories Categorie ,bool isOnline,int Limit)
        {
            No = no;
            Categorie = categorie;
            
            isOnline = IsOnline;
            Limit = limit;

        }
        public List <Student> Students
        {
            get => students;
            set
            {
                if (!IsOnline)
                {
                    limit = 20;
                    students = new List<Student>(limit);

                }
                else
                {
                    limit = 10;
                    students = new List<Student>(limit);
                }
                


            }
           





        }
        public void StudentInfo(Student student)
        {
            Console.WriteLine($"Name : {student.Name} \n Surname : {student.Surname} \n  Groupno : {student.GroupNo} \n Id : {student.Id} \n Guaranty: {student.Guaranty}   ");
            
        }










    }
}
