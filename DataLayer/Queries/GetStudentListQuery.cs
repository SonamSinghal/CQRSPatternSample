using DataLayer.Model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Queries
{
    public class GetStudentListQuery:IRequest<List<StudentModel>>
    {
    }

    //public record GetStudentListQuery() : IRequest<List<StudentModel>>;
}
