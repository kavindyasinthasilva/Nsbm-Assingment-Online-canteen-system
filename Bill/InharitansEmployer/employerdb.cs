using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bill.InharitansEmployer
{
    class employerdb:employer
    {


        string name;
        string age;
        string address;
        string nic;
        string de;

        public employerdb(string name, string age, string addres, string nic, string de) : base(name,age,addres,nic,de)

        {


            this.name = name;
            this.age = age;
            this.address = addres;
            this.nic = nic;
            this.de = de;

        }

      
        public string  setname()
        {

            return name;


        }

        public string setage()
        {

            return age;



        }

        public string setadd()
        {

            return address;

        }

        public string setnic()
        {



            return nic;
        }

        public string  setde()
        {
            

            

                return de;




        }







    }
}
