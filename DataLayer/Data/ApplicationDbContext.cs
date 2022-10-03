using DataLayer.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Data
{
    public class ApplicationDbContext : DbContext
    {
        private readonly IConfiguration _configuration;
        private readonly DbContextOptions<ApplicationDbContext> _options;

        public ApplicationDbContext(IConfiguration configuration,
            DbContextOptions<ApplicationDbContext> options):base(options)
        {
            _configuration = configuration;
            _options = options;
        }

        public DbSet<StudentModel> StudentsData { get; set; }
    }
}
