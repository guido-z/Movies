using DB;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace DAL
{
    public class BaseDAO<TObject> where TObject : class
    {
        protected readonly DbContext _context;

        #region Constructor

        public BaseDAO()
        {
            _context = new PeliculasEntities1();
        }

        public BaseDAO(DbContext context)
        {
            _context = context;
        }

        #endregion

        #region Metodos

        public TObject FindById(int id)
        {
            return _context.Set<TObject>().Find(id);
        }

        public TObject FindByQuery(Expression<Func<TObject, bool>> expression)
        {
            return _context.Set<TObject>().FirstOrDefault(expression);
        }

        public IEnumerable<TObject> ListAll()
        {
            return this._context.Set<TObject>();
        }

        public IEnumerable<TObject> ListByQuery(Expression<Func<TObject, bool>> expression)
        {
            return _context.Set<TObject>().Where(expression);
        }

        public int Save(TObject entity)
        {
            try
            {
                _context.Set<TObject>().Add(entity);
                return _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int Update(TObject entity)
        {
            try
            {
                _context.Entry(entity).State = EntityState.Modified;
                return _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        
        public int Delete(int id)
        {
            try
            {
                _context.Set<TObject>().Remove(this.FindById(id));
                return _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion
    }
}
