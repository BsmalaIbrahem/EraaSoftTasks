﻿using DataLayer.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repository
{
    public class MainRepository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;

        public MainRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>>? filter = null,
            Func<IQueryable<T>, IIncludableQueryable<T, object>>? includeChain = null,
            bool asNoTracking = false, int? skip = null, int? take = null,
            Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null
        )
        {
            IQueryable<T> query = _context.Set<T>();

            if (filter != null)
                query = query.Where(filter);

            if (includeChain != null)
                query = includeChain(query);

            if (asNoTracking)
                query = query.AsNoTracking();

            if (orderBy != null)
                query = orderBy(query);

            if (skip.HasValue && take.HasValue)
                query = query.Skip(skip.Value).Take(take.Value);

            return await query.ToListAsync();
        }

        public async Task<T?> GetOneAsync(
            Expression<Func<T, bool>>? filter = null,
            Func<IQueryable<T>, IIncludableQueryable<T, object>>? includeChain = null,
            bool asNoTracking = false)
        {
            return (await GetAllAsync(filter, includeChain, asNoTracking)).FirstOrDefault();
        }


        public async Task<T?> GetOneAsync(Expression<Func<T, bool>>? expression = null, Expression<Func<T, object>>[]? Includes = null,
            Func<IQueryable<T>, IIncludableQueryable<T, object>>? includeChain = null, bool AsNoTracking = false)
        {
            var data = await GetAllAsync(expression, includeChain: includeChain, asNoTracking: AsNoTracking);
            return data.FirstOrDefault();
        }

        public async Task<int> CountAsync(Expression<Func<T, bool>>? expression = null)
        {
            var query = _context.Set<T>().AsQueryable();
            if (expression != null)
            {
                query = query.Where(expression);
            }
            return await  query.CountAsync();
        }

        public async Task AddAsync(T entity)
        {
            try
            {
               await _context.Set<T>().AddAsync(entity);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while adding the entity.", ex);
            }
            
        }
        public async Task UpdateAsync(T entity)
        {
            try
            {
                 _context.Set<T>().Update(entity);
                await SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while Updating the entity.", ex);
            }
        }
        public async Task DeleteAsync(Expression<Func<T, bool>> expression)
        {
            var item = await _context.Set<T>().FirstOrDefaultAsync(expression);
            if (item == null)
            {
                throw new Exception("Entity not found.");
            }
            try
            {
                _context.Set<T>().Remove(item);
                await SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while deleting the entity.", ex);
            }
        }
        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        
    }
    
}
