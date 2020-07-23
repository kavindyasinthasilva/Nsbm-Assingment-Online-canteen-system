using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bill.Properties
{
    class mainsalary
    {

      public  int NiC;
      public  int  Bsalary;
      public int houres;
      public   int  ye;

        public void salary(int n,int b,int h,int y)

        {

            this.NiC = n;
            this.Bsalary = b;
            this.houres = h;
            this.ye = y;

            basicsal db = new basicsal();

               db.newdata(NiC,Bsalary,houres,ye);


        }

    }
}
