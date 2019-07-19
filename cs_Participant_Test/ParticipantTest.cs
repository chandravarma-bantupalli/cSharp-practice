using System;
using Xunit;
using FluentAssertions;
using FluentAssertions.Numeric;
using cs_Participant;

namespace cs_Participant_Test
{
    public class ParticipantTest
    {
        

        [Fact]
        public void TestValidateMobileNum()
        {
            Participant testParticipant = new Participant("Test");

            string mobileNumber = Convert.ToString(testParticipant.mobileNum);
            int inputLen = mobileNumber.Length;
            string expectedMobileNum = "9876543210";

            inputLen.Should().Equals(expectedMobileNum.Length);
         
        }

        [Fact]
        public void TestValidateUserEmail()
        {
            Participant testParticipant = new Participant("Test");

            string email = testParticipant.email;
            bool containsAt = email.Contains("@");

            containsAt.Should().BeTrue();
        }
    }
}
