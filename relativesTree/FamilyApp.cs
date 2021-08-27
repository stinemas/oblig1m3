using System.Collections.Generic;

namespace relativesTree
{
    class FamilyApp
    {
        public string WelcomeMessage = "Velkommen elns..";
        public string CommandPrompt = ">: ";
        private List<Person> people;


        public FamilyApp(params Person[] people)
        {
            this.people = new List<Person>(people);
        }

        public string HandleCommand(string command)
        {
            return null;
        }
    }
}