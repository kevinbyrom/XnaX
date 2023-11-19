using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace XnaX.Framework
{
    public abstract class GameEntityBase : GameComponent, IGameEntity
    {
        public int ID { get; set; }


        public GameEntityBase(Game game) : base(game)
        {
        }

        public GameEntityBase(Game game, int id) : base(game)
        {
            this.ID = id;
        }


        public abstract void Update(GameTime gameTime);
     
        public abstract void Draw(GameTime gameTime);

    }
}
