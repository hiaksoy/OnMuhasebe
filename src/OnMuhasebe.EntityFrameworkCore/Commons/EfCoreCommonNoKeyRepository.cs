﻿using OnMuhasebe.EntityFrameworkCore;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;

namespace OnMuhasebe.Commons;
public class EfCoreCommonNoKeyRepository<TEntity> : EfCoreRepository<OnMuhasebeDbContext, TEntity>, ICommonNoKeyRepository<TEntity> where TEntity : class, IEntity
{
    public EfCoreCommonNoKeyRepository(IDbContextProvider<OnMuhasebeDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }

    public async Task<TEntity> FromSqlRawSingleAsync(string sql, params object[] parameters)
        {
        var dbSet = await GetDbSetAsync();
        return (await dbSet.FromSqlRaw(sql, parameters).ToListAsync()).FirstOrDefault();
        }

    public async Task<IList<TEntity>> FromSqlRawAsync(string sql, params object[] parameters)
    {
        var dbset = await GetDbSetAsync();
        return await dbset.FromSqlRaw(sql, parameters).ToListAsync();
    }

    
}
