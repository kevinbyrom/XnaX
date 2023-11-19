using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using XnaX.Framework.Graphics;

namespace XnaX.Framework.World.Graphics
{
    public class EntitySprite : Sprite
    {
        public IEntity Entity { get; set; }
    }
}
