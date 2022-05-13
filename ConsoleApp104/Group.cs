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
        List<Student> students = new List<Student>();
        public string name;
        public string no;
        
        public Group(int no,Categories Categorie ,bool isOnline,int Limit)
        {
            No = no;
            Categorie = categorie;
            
            isOnline = IsOnline;
            Limit = limit;

        }



       


    }
}
