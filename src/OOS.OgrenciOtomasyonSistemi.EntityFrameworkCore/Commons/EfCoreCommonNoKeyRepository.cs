using System.Collections.Generic;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;

namespace OOS.OgrenciOtomasyonSistemi.Commons;

public class EfCoreCommonNoKeyRepository<TEntity> : EfCoreRepository<OgrenciOtomasyonSistemiDbContext, TEntity>,
    ICommonNoKeyRepository<TEntity> where TEntity : class, IEntity
{
    public EfCoreCommonNoKeyRepository(IDbContextProvider<OgrenciOtomasyonSistemiDbContext> dbContextProvider) 
        : base(dbContextProvider)
    {
    }

    public async Task<TEntity> FromSqlRawSingleAsync(string sql, params object[] parameters)
    {
        var dbSet = await GetDbSetAsync();
        return (await dbSet.FromSqlRaw(sql, parameters).ToListAsync()).FirstOrDefault();
    }

    public async Task<IList<TEntity>> FromSqlRawAsync(string sql, params object[] parameters)
    {
        var dbSet = await GetDbSetAsync();
        return await dbSet.FromSqlRaw(sql, parameters).ToListAsync();
    }
}