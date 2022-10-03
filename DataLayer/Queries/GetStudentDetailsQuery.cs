using DataLayer.Model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Queries
{
    public class GetStudentDetailsQuery : IRequest<StudentModel>
    {
        public int Id { get; }
        public GetStudentDetailsQuery(int id)
        {
            Id = id;
        }
    }
}
