using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    public class Person
    {
        private string FName;
        private string LName;
        private int Number;
        private  string Email;
        public Person(string fn,String ln,String mail,int N)
        {
            FName = fn;
            LName = ln;
            Email = mail;
            Number = N;
        }
    }
}
