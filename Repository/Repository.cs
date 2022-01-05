using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Repository
{
    public interface Repository<TEntity, ID>
    {
        TEntity FindById(ID id);
        List<TEntity> FindByIDs(Collection<ID> ids);
        List<TEntity> FindAll();
        Boolean DeleteByID(ID id);
        Boolean DeleteByIDs(Collection<ID> ids);

        //? saves the Entity, if already exists updates it, then return the entity with the given id by the database:
        TEntity Save(TEntity E);
    }
}