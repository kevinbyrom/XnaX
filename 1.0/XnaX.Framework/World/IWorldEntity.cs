using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using XnaX.Framework.Graphics;


namespace XnaX.Framework.World
{

    public interface IWorldEntity : IGameEntity 
    {
        Vector3 Position;
        Vector3 Velocity;
        Vector3 Facing;
        Sprite Sprite;
    }

}
