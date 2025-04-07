using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Proyecto_Tienda_Virtual.Data_base
{
    public class DatabaseManager<T> where T : class
    {
        private readonly AppDbContext _context;
        private readonly DbSet<T> _dbSet;

        public DatabaseManager(AppDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public void Add(T entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            try
            {
                return _dbSet.ToList();
            }
            catch (System.Data.SqlTypes.SqlNullValueException ex)
            {
                Console.WriteLine("Error: Se intentó acceder a un valor NULL en la base de datos.");
                Console.WriteLine(ex.Message);
            }
            return _dbSet;
         
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
            _context.SaveChanges();
        }
    }
    }
