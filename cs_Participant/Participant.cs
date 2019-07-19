using System;

namespace cs_Participant
{
    public class Participant
    {
        /// <summary>
        /// This is the Participant Case Study with Encapsualtion
        /// </summary>
        
        //Here are my properties of the Participant Class
        public string particiantName;
        private string _fromOrg;
        public string courseTaken;
        private long _mobileNum;
        private string _email;

        #region CONSTANTS
        public const int totalDays = 140;
        public const int noOfTopics = 12;
        public const int noOfAssignments = 10;
        #endregion

        #region Encapsulatng Properties
        //Here I am encapsualting the private properties of Participant Class
        public string fromOrg{
            get
            {
                return _fromOrg;
            }
            set
            {
                _fromOrg = value;
            }
        }

        public long mobileNum
        {
            get; set;
        }

        public string email
        {
            get; set;
        }

        #endregion

        #region Participant Constructor
        //Here are the constructors of my Participant Class
        public Participant()
        {
            Console.WriteLine("Enter the Participant Name: ");
            this.particiantName = Console.ReadLine();
            Console.WriteLine("Enter the course taken by the Participant: ");
            this.courseTaken = Console.ReadLine();
            this.setContactDetails();
        }

        public Participant(string name)
        {
            this.mobileNum = 9563871203;
            this.email = "participant@gmail.com";
        }

        

        #endregion

        //Method to set contact details of the Participant
        private void setContactDetails()
        {
            Console.WriteLine($"Set the contact details for {this.particiantName}");
            Console.WriteLine("Which organization is the participant from: ");
            this.fromOrg = Console.ReadLine();
            Console.WriteLine("Enter praticipant's Mobile Number: ");
            string mobNum = Console.ReadLine();
            this.mobileNum = Convert.ToInt64(mobNum);
            Console.WriteLine("Enter participant's email: ");
            this.email = Console.ReadLine();
        }

        public Participant showParticipant(Participant myParticipant)
        {
            return myParticipant;
        }


    }
}
