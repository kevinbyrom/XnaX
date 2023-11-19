using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;


namespace XnaX.Framework
{
    public abstract class EntityGroupBase<TEntity> : GameEntityBase, IEntityGroup<TEntity>
        where TEntity : IGameEntity 
    {
        protected Dictionary<int, TEntity> entities;


        public EntityGroupBase(Game game) : base(game) 
        {
            this.entities = new Dictionary<int,TEntity>();
        }


        public EntityGroupBase(Game game, int id) : base(game, id) 
        {
            this.entities = new Dictionary<int,TEntity>();
        }


        #region Registration Methods

        /// <summary>
        /// Registers an entity to the group
        /// </summary>
        /// <param name="entity"></param>
        
        public void RegisterEntity(TEntity entity)
        {
            if (!this.entities.ContainsKey(entity.ID))
                this.entities.Add(entity.ID, entity);
        }


        /// <summary>
        /// Removes an entity from the group
        /// </summary>
        /// <param name="entity"></param>
        
        public void RemoveEntity(TEntity entity)
        {
            if (this.entities.ContainsKey(entity.ID))
                this.entities.Remove(entity.ID);
        }


        /// <summary>
        /// Clears registered entities from the group
        /// </summary>
        
        public void ClearRegisteredEntities()
        {
            this.entities.Clear();
        }


        /// <summary>
        /// Gets a registered entity by a given ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        
        public TEntity GetEntityByID(int id)
        {
            if (this.entities.ContainsKey(id))
                return this.entities[id];
            else
                return default(TEntity);
        }

        #endregion


        /// <summary>
        /// Updates the registered entities
        /// </summary>
        /// <param name="gameTime"></param>
        
        public override void Update(GameTime gameTime)
        {
            foreach (TEntity entity in entities.Values)
                entity.Update(gameTime);
        }


        /// <summary>
        /// Draws the registers entities
        /// </summary>
        /// <param name="gameTime"></param>
        
        public override void Draw(GameTime gameTime)
        {
            foreach (TEntity entity in entities.Values)
                entity.Draw(gameTime);
        }

    }
}
