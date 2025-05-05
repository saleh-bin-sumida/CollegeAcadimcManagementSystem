﻿namespace ASP.NET_API_Template.Core.Interfaces;

public interface IBaseRepository<T> where T : class
{
    #region Get Methods
    Task<T> GetByIdAsync(int id);
    Task<T> GetByIdAsync(int? id);
    Task<T> GetByIdAsync(Guid id);
    Task<T?> GetByIdAsync(Guid? id);
    #endregion

    #region Find Methods
    Task<T> FindAsync(
        Expression<Func<T, bool>> criteria,
        params Expression<Func<T, object>>[] includes);

    Task<TResult> FindWithSelectionAsync<TResult>(
        Expression<Func<T, bool>> criteria,
        params Expression<Func<T, object>>[] includes);
    #endregion

    #region Read Data Methods
    Task<List<T>> GetAllDataAsync(
        Expression<Func<T, object>> orderBy,
        Expression<Func<T, bool>>? criteria = null,
        params Expression<Func<T, object>>[] includes);

    Task<List<TResult>> GetAllDataWithSelectionAsync<TResult>(
        Expression<Func<T, object>> orderBy,
        Expression<Func<T, bool>>? criteria = null,
        params Expression<Func<T, object>>[] includes);

    Task<PagedResult<T>> GetPagedDataAsync(
        Expression<Func<T, object>> orderBy,
        Expression<Func<T, bool>>? criteria = null,
        int pageNumber = 1,
        int pageSize = 10,
        params Expression<Func<T, object>>[] includes);

    Task<PagedResult<TResult>> GetPagedDataWithSelectionAsync<TResult>(
        Expression<Func<T, object>> orderBy,
        Expression<Func<T, bool>>? criteria = null,
        int pageNumber = 1,
        int pageSize = 10,
        params Expression<Func<T, object>>[] includes);
    #endregion

    #region Add Methods
    Task<T> AddAsync(T entity);
    Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> entities);
    #endregion

    #region Update Methods
    T Update(T entity);
    #endregion

    #region Delete Methods
    Task DeleteAsync(T entity);
    System.Threading.Tasks.Task DeleteRange(IEnumerable<T> entities);
    #endregion

    #region Attach Methods
    void Attach(T entity);
    void AttachRange(IEnumerable<T> entities);
    #endregion

    #region Query Methods
    Task<bool> AnyAsync(Expression<Func<T, bool>> criteria);
    IQueryable<T> Where(Expression<Func<T, bool>> criteria);
    IQueryable<T> AsQueryable();
    IEnumerable<T> ExecuteRawSql(string query);
    IQueryable<T> IgnoreQueryFilters();
    #endregion

    #region Helper Methods


    #endregion

}
