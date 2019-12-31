using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManagement.Application.Courses.Commands.GenerateEntryCode
{
    public interface IGenerateEntryCodeCommand
    {
        string GenerateEntryCode(int id);
    }
}
