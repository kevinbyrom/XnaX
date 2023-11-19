using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace XnaX.Framework.Graphics
{
    public abstract class ScreenViewBase : ScreenEntityBase
    {
        public Viewport Viewport;



        public ScreenViewBase(Game game) : base(game)
        {
        }


        /// <summary>
        /// Handles drawing of the view
        /// </summary>
        /// <param name="spriteBatch"></param>
        /// <param name="gameTime"></param>
        
        public override void Draw(GameTime gameTime)
        {

            // Set the viewport

            this.screenManager.PushViewport(this.Viewport);


            // Draw content

            DrawContent(gameTime);


            // Restore viewport

            this.screenManager.PopViewport();

        }


        /// <summary>
        /// Handles drawing of view content
        /// </summary>
        /// <param name="gameTime"></param>
        
        protected abstract void DrawContent(GameTime gameTime);
 
    }
}
