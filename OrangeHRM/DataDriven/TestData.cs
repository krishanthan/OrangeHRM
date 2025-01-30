using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM.DataDriven
{
    public class TestDatas
    {

        public String GetUserName(String Key)
        {
            Dictionary<String, String> Usernames = new Dictionary<String, String>()
            {

                {"User1","ABCD" },
                {"User2","BDF" },


            };

            var MyKeyValue = Usernames.FirstOrDefault().Value;
            return MyKeyValue;

             




        }

    }
}
