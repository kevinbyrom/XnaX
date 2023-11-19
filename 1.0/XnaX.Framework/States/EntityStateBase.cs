using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;


namespace XnaX.Framework
{
    public class EntityStateBase<TEntity> : IState
        where TEntity : IGameEntity
    {
        TEntity Owner { get; set; }
        

        public EntityStateBase(TEntity entity)
        {
            this.Owner = entity;
        }


        /// <summary>
        /// Handler for entering state
        /// </summary>
        /// <param name="gameTime">Current game time</param>
        
        public virtual void Entering(GameTime gameTime)
        {
        }


        /// <summary>
        /// Handler for exiting state
        /// </summary>
        /// <param name="gameTime">Current game time</param>
        
        public virtual void Exiting(GameTime gameTime)
        {
        }


        /// <summary>
        /// Handler for state updates
        /// </summary>
        /// <param name="gameTime">Current game time</param>
        
        public virtual void Update(GameTime gameTime)
        {
            
        }
    }
}
