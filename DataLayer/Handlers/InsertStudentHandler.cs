using DataLayer.Commands;
using DataLayer.Model;
using DataLayer.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Handlers
{
	public class InsertStudentHandler : IRequestHandler<InsertStudentCommand, StudentModel?>
	{
		private readonly IStudentRepository _studentRepository;

		public InsertStudentHandler(IStudentRepository studentRepository)
		{
			_studentRepository = studentRepository;
		}

		public Task<StudentModel?> Handle(InsertStudentCommand request, CancellationToken cancellationToken)
		{
			return _studentRepository.AddStudent(request.Student);
		}
	}
}
