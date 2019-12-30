using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManagement.Application.Users.Exceptions
{
    public class TutorNotExistsException : Exception
    {
        public TutorNotExistsException(int tutorId) 
            : base(String.Format("Doesn't exsist tutor with id: ", tutorId))
        {
        }
    }
}
