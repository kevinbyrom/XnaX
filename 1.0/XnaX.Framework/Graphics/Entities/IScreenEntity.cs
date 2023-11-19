using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace XnaX.Framework.Graphics
{
    public interface IScreenEntity : IGameEntity, IDrawable 
    {
        Vector2 Origin;
        Vector2 Position;
        Vector2 Size;
        float Depth;
        bool IsVisible;
    }
}
