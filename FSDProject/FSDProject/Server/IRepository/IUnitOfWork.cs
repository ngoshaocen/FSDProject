using FSDProject.Shared.Domain;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace FSDProject.Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save(HttpContext httpContext);
        IGenericRepository<Staff> Staffs { get; }
        IGenericRepository<Job> Jobs { get; }
        IGenericRepository<Company> Companys { get; }
    }
}