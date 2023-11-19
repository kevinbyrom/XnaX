using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace XnaX.Framework.Graphics
{
    public class ScreenLayer : ScreenElement 
    {
        public Viewport Viewport { get; set; }

        public ScreenLayer(Game game) : base(game)
        {

        }

        #region Draw Routines

        public virtual void Draw(SpriteBatch spritebatch, GameTime gametime)
        {

            // Set the viewport to only draw in this container

            this.ScreenManager.PushViewport(this.Viewport);


            // Draw the content

            DrawContent(spritebatch, gametime);


            // Reset the viewport

            this.ScreenManager.PopViewport();
        }


        protected virtual void DrawContent(SpriteBatch spriteBatch, GameTime gameTime)
        {            
        }
        
        #endregion


    }
}
