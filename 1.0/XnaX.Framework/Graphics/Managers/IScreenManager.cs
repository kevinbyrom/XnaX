using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace XnaX.Framework.Graphics
{
    public interface IScreenManager
    {
        Viewport CurrentViewport { get; set; }
        SpriteBatch CurrentSpriteBatch { get; set; }

        void SetScreenSize(int width, int height, bool fullScreen);
        void SetFullScreen(bool fullScreen);
        void ToggleFullScreen();

        void PushViewport(Viewport viewport);
        Viewport PopViewport();
        
        void PushSpriteBatch(SpriteBatch spriteBatch);
        SpriteBatch PopSpriteBatch();
    }
}
