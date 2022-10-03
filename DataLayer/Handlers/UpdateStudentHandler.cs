using DataLayer.Commands;
using DataLayer.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Handlers
{
	public class UpdateStudentHandler : IRequestHandler<UpdateStudentCommand, bool>
	{
		private readonly IStudentRepository _studentRepository;

		public UpdateStudentHandler(IStudentRepository studentRepository)
		{
			_studentRepository = studentRepository;
		}

		public Task<bool> Handle(UpdateStudentCommand request, CancellationToken cancellationToken)
		{
			return _studentRepository.UpdateStudent(request.Student);
		}
	}
}
