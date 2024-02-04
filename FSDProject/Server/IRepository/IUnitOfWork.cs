using FSDProject.Server.IRepository;
using FSDProject.Shared.Domain;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FSDProject.Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save(HttpContext httpContext);
        IGenericRepository<Consultant> Consultants { get; }
        IGenericRepository<ConsultationSession> ConsultationSessions { get; }
        IGenericRepository<JobSeeker> JobSeekers { get; }
    }
}