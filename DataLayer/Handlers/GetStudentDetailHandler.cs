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
    public class GetStudentDetailHandler : IRequestHandler<GetStudentDetailsQuery, StudentModel>
    {
        private readonly IMediator _mediator;

        public GetStudentDetailHandler(IMediator mediator)
        {
            _mediator = mediator;
        }
        public async Task<StudentModel?> Handle(GetStudentDetailsQuery request, CancellationToken cancellationToken)
        {
            var students = await _mediator.Send(new GetStudentListQuery());
            var response = students.FirstOrDefault(x => x.Id == request.Id)??null;
            return response;
        }
    }
}
