using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAn
{
    internal class account
    {
        private string name;
        private string email;
        private string phone;
        private string tentaikhoan;
        private string matkau;
        private string xacmk;

        public account()
        {
        }

        public account(string name, string email, string phone, string tentaikhoan, string matkau, string xacmk)
        {
            this.Name = name;
            this.Email = email;
            this.Phone = phone;
            this.Tentaikhoan = tentaikhoan;
            this.Matkau = matkau;
            this.Xacmk = xacmk;
        }

        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Tentaikhoan { get => tentaikhoan; set => tentaikhoan = value; }
        public string Matkau { get => matkau; set => matkau = value; }
        public string Xacmk { get => xacmk; set => xacmk = value; }

        public string CreateAccount()
        {
            return $"{name}|{email}|{phone}|{tentaikhoan}|{matkau}|{xacmk}\n";
        }
    }
}
