using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Persistence.Repositories;
public class UnitOfWork : IUnitOfWork
{
    private readonly AppDBContext _context;

    public UnitOfWork(AppDBContext context)
    {
        _context = context;
    }
    public async Task Commit(CancellationToken cancellationToken)
    {
        await _context.SaveChangesAsync(cancellationToken);
    }
}