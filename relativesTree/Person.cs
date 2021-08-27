using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace relativesTree
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        public int Id;
        public int BirthYear;
        public int DeathYear;
        public Person Father;
        public Person Mother;

        public string GetDescription()
        {
            List<string> personInfos = new List<string>();

            if (FirstName != null) personInfos.Add(FirstName);
            if (LastName != null) personInfos.Add(LastName);
            if (Id > 0) personInfos.Add($"(Id={Id})");
            if (BirthYear > 0) personInfos.Add($"Født: {BirthYear}");
            if (DeathYear > 0) personInfos.Add($"Død: {DeathYear}");

            if (Father != null)
            {
                personInfos.Add($"Far: {Father.FirstName} (Id={Father.Id})");
            }

            if (Mother != null)
            {
                personInfos.Add($"Mor: {Mother.FirstName} (Id={Mother.Id})");
            }

            return string.Join(' ', personInfos);
        }
    }
}
