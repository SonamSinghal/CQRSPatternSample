using DataLayer.Model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Commands
{
	public class UpdateStudentCommand : IRequest<bool>
	{
        public StudentModel Student { get; set; }

        public UpdateStudentCommand(StudentModel student)
		{
			Student = student;
		}

	}
}
