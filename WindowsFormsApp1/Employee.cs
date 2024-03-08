using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Employee
    {
        private int idEmployee;
        private string Ename;
        private DateTime dateOfBirth;
        private string gender;
        private string Eaddress;
        private string phoneNumber;

        public Employee(int idEmployee, string ename, DateTime dateOfBirth, string gender, string eaddress, string phoneNumber)
        {
            this.idEmployee = idEmployee;
            Ename = ename;
            this.dateOfBirth = dateOfBirth;
            this.gender = gender;
            Eaddress = eaddress;
            this.phoneNumber = phoneNumber;
        }

        public int IdEmployee { get => idEmployee; set => idEmployee = value; }
        public string Ename1 { get => Ename; set => Ename = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Eaddress1 { get => Eaddress; set => Eaddress = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
    }
}
