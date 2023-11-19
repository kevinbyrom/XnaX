using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace XnaX.Framework.World
{

    public class WorldEntityBase : GameEntityBase, IWorldEntity
    {
        public Vector3 Position;
        public Vector3 Velocity;
        public Vector3 Facing;


        public WorldEntityBase(Game game) : base(game)
        {
            this.Position = Vector3.Zero;
            this.Velocity = Vector3.Zero;
            this.Facing = Vector3.Zero;
        }

        public WorldEntityBase(Game game, int id) : base(game, id)
        {
            this.Position = Vector3.Zero;
            this.Velocity = Vector3.Zero;
            this.Facing = Vector3.Zero;
        }
    }
}
