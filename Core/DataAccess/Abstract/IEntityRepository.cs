using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.Abstract
{
    public interface IEntityRepository<T>
        where T : class, IEntity, new()
    {
        //Buradaki filter=null o demekdirki yeni filter vermesende olar vermedikde ise butun datalari getirecek
        //T:class class olmali deyil. Refeance tip ola bilir ola demekdir.
        //T:IEntity Entity ola bilir ve ientityden miras alan ola bilir.
        //Nuget basqalarin kodlarini istifade edeceyimiz yukluyeceyimiz yerdir.
        //Using c# aiddir .ve usimg bitdkden sonra gb deyir  sil meni Idisposiable pattern impdir

        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
