using DataLayer.Model;
using DataLayer.Queries;
using DataLayer.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Handlers
{
    public class GetStudentListHandler : IRequestHandler<GetStudentListQuery, List<StudentModel>>
    {
        private readonly IStudentRepository _studentRepository;

        public GetStudentListHandler(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public Task<List<StudentModel>> Handle(GetStudentListQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_studentRepository.GetAllStudents());
        }
    }
}
