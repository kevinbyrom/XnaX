using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace XnaX.Framework.Graphics
{
    public struct ScreenParams
    {
        Vector2 Origin;
        Vector2 Position;
        Vector2 Size;
        float Rotation;
        float Scale;
        float Depth;
        Color Color;
        bool IsVisible;
    }

    public interface IScreenEntity : IDrawable 
    {
        IScreenManager ScreenManager { get; set; }

        ScreenParams Screen;

        void Draw(SpriteBatch spriteBatch, GameTime gameTime);

    }
}
