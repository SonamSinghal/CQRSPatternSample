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
	internal class DeleteStudentHandler : IRequestHandler<DeleteStudentCommand, bool>
	{
		private readonly IStudentRepository _studentRepository;

		public DeleteStudentHandler(IStudentRepository studentRepository)
		{
			_studentRepository = studentRepository;
		}

		public Task<bool> Handle(DeleteStudentCommand request, CancellationToken cancellationToken)
		{
			return _studentRepository.DeleteStudent(request.Id);
		}
	}
}
