using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace XnaX.Framework
{
    public interface IEntityGroup<TEntity> : IGameEntity 
        where TEntity : IGameEntity
    {
        void RegisterEntity(TEntity entity);
        void RemoveEntity(TEntity entity);
        void ClearRegisteredEntities();
        TEntity GetEntityByID(int id);
    }
}
