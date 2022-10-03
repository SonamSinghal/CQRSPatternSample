using DataLayer.Model;
using MediatR;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Commands
{
	public class InsertStudentCommand :IRequest<StudentModel?>
	{
		public StudentModel Student { get; set; }

		public InsertStudentCommand(StudentModel student)
		{
			Student = student;
		}
	}

	//public record InsertStudentCommand(string FirstName, string LastName, string Email):IRequest<StudentModel>;
}
