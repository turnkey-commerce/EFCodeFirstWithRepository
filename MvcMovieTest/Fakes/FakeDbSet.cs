using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace MvcMovieTest.Fakes {
    public class FakeDbSet<T>  : IDbSet<T> where T : class {

        readonly IList<T> _container = new List<T>();

        #region IDbSet<T> Members

        public T Add(T entity) {
            _container.Add(entity);
            return entity;
        }

        public T Attach(T entity) {
            _container.Add(entity);
            return entity;
        }

        public TDerivedEntity Create<TDerivedEntity>() where TDerivedEntity : class, T {
            throw new NotImplementedException();
        }

        public T Create() {
            throw new NotImplementedException();
        }

        public T Find(params object[] keyValues) {
            throw new NotImplementedException();
        }

        public System.Collections.ObjectModel.ObservableCollection<T> Local {
            get { throw new NotImplementedException(); }
        }

        public T Remove(T entity) {
            throw new NotImplementedException();
        }

        #endregion

        #region IEnumerable<T> Members

        public IEnumerator<T> GetEnumerator() {
            return _container.GetEnumerator();
        }

        #endregion

        #region IEnumerable Members

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
            throw new NotImplementedException();
        }

        #endregion

        #region IQueryable Members

        public Type ElementType {
            get { throw new NotImplementedException(); }
        }

        public System.Linq.Expressions.Expression Expression {
            get { throw new NotImplementedException(); }
        }

        public IQueryProvider Provider {
            get { throw new NotImplementedException(); }
        }

        #endregion
    }
}
