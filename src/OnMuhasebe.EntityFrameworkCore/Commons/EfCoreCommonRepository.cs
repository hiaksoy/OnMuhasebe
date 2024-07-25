﻿using OnMuhasebe.EntityFrameworkCore;
using System.Linq.Expressions;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;

namespace OnMuhasebe.Commons;
public class EfCoreCommonRepository<TEntity> : EfCoreRepository<OnMuhasebeDbContext, TEntity, Guid>, ICommonRepository<TEntity>
    where TEntity : class, IEntity<Guid>
{
    public EfCoreCommonRepository(IDbContextProvider<OnMuhasebeDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }

    public async Task<TEntity> GetAsync(object id, Expression<Func<TEntity, bool>> predicate = null, params Expression<Func<TEntity, object>>[] includeProperties)
    {
        var queryable = await WithDetailsAsync(includeProperties);
        TEntity entity;
        if (predicate != null)
        {
            entity = await queryable.FirstOrDefaultAsync(predicate);
            if (entity == null)
                throw new EntityNotFoundException(typeof(TEntity), id);
            return entity;
        }

        entity = await queryable.FirstOrDefaultAsync();
        if (entity == null)
            throw new EntityNotFoundException(typeof(TEntity), id);
        return entity;
    }
    public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate = null, params Expression<Func<TEntity, object>>[] includeProperties)
    {
        var queryable = await WithDetailsAsync(includeProperties);

        if (predicate != null)
            return await queryable.FirstOrDefaultAsync(predicate);

        return await queryable.FirstOrDefaultAsync();
    }
    public async Task<TEntity> GetAsync(object id, Expression<Func<TEntity, bool>> predicate = null)
    {
        var queryable = await WithDetailsAsync();
        TEntity entity;
        if (predicate != null)
        {
            entity = await queryable.FirstOrDefaultAsync(predicate);
            if (entity == null)
                throw new EntityNotFoundException(typeof(TEntity), id);
            return entity;
        }
        entity = await queryable.FirstOrDefaultAsync();
        if (entity == null)
            throw new EntityNotFoundException(typeof(TEntity), id);
        return entity;
    }
    public async Task<List<TEntity>> GetPagedListAsync<TKey>(int skipCount, int maxResultCount, Expression<Func<TEntity, bool>> predicate = null, Expression<Func<TEntity, TKey>> orderBy = null, params Expression<Func<TEntity, object>>[] includeProperties)
    {
        var queryable = await WithDetailsAsync(includeProperties);
        if (predicate != null)
            queryable = queryable.Where(predicate);
        if (orderBy != null)
            queryable = queryable.OrderBy(orderBy);
        return await queryable.Skip(skipCount).Take(maxResultCount).ToListAsync();
    }
    public async Task<List<TEntity>> GetPagedListAsync<TKey>(int skipCount, int maxResultCount, Expression<Func<TEntity, bool>> predicate = null, Expression<Func<TEntity, TKey>> orderBy = null)
    {
        var queryable = await WithDetailsAsync();
        if (predicate != null)
            queryable = queryable.Where(predicate);
        if (orderBy != null)
            queryable = queryable.OrderBy(orderBy);
        return await queryable.Skip(skipCount).Take(maxResultCount).ToListAsync();
    }
    public async Task<List<TEntity>> GetPagedLastListAsync<TKey>(int skipCount, int maxResultCount, Expression<Func<TEntity, bool>> predicate = null, Expression<Func<TEntity, TKey>> orderBy = null, params Expression<Func<TEntity, object>>[] includeProperties)
    {
        var queryable = await WithDetailsAsync(includeProperties);
        if (predicate != null)
            queryable = queryable.Where(predicate);
        if (orderBy != null)
            queryable = queryable.OrderByDescending(orderBy);
        return await queryable.Skip(skipCount).Take(maxResultCount).ToListAsync();
    }
    public async Task<string> GetCodeAsync(Expression<Func<TEntity, string>> propetrySelector, Expression<Func<TEntity, bool>> predicate = null)
    {
        static string CreateNewCode(string code)
        {
            var number = "";

            foreach (var character in code)
            {
                if (char.IsDigit(character))
                    number += character;
                else
                    number = "";
            }

            var newNumber = number == "" ? "1" : (long.Parse(number) + 1).ToString();
            var difference = code.Length - newNumber.Length;
            if (difference < 0)
                difference = 0;

            var newCode = code.Substring(0, difference);
            newCode += newNumber; //number değilde newNumber olabilir

            return newCode;
        }

        var dbSet = await GetDbSetAsync();
        var maxCode = predicate == null ? await dbSet.MaxAsync(propetrySelector) : await dbSet.Where(predicate).MaxAsync(propetrySelector);
        return maxCode == null ? "0000000000000001" : CreateNewCode(maxCode);
    }
    public async Task<IList<TEntity>> FromSqlRawAsync(string sql, params object[] parameters)
    {
        var context = await GetDbContextAsync();
        return await context.Set<TEntity>().FromSqlRaw(sql, parameters).ToListAsync();

    }
    public async Task<bool> AnyAsync(Expression<Func<TEntity, bool>> predicate = null)
        {
           var dbSet = await GetDbSetAsync();
           return predicate == null ? await dbSet.AnyAsync() : await dbSet.AnyAsync(predicate);
        }
}
