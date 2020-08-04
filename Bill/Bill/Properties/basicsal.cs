using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Bill.Properties
{
    class Basicsal : mainsalary
    {

        public int NiC;
        public int Bsalary;
        public int houres;
        public int ye;

        public Basicsal(int x, int y, int z, int j) :base(x,y,z,j)
        {

            this.NiC = x;
            this.Bsalary = y;
            this.houres = z;
            this.ye = j;


        }

        public int setnic()
        {
             return NiC;


        }

        public  int setBsalary()
        {


            return Bsalary;
        }

        public  int sethoures()
        {

            return houres;

        }

        public  int setyear()
        {


            return ye;


        }

        public int Updatesalary()
        {

            int newsalary;

            if(ye >= 5)
            {

                newsalary = Bsalary * 5000;

                return newsalary;

            }
            else
            {

                newsalary = Bsalary;

                return newsalary;


            }





        }



       

      
        

        

         
            
         
            

         


        }
      


        

    
}
