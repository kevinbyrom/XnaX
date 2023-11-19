using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;


namespace XnaX.Framework.Graphics
{
    public class ScreenManager : GameComponent, IScreenManager  
    {
        private GraphicsDeviceManager deviceManager;
        private Stack<Viewport> viewportStack;
        private Stack<SpriteBatch> spriteBatchStack;


        public Viewport CurrentViewport
        {
            get
            {
                return this.deviceManager.GraphicsDevice.Viewport;
            }
            set
            {
                SetViewport(value);
            }
        }

        public SpriteBatch CurrentSpriteBatch
        {
            get
            {
                return this.spriteBatchStack.Peek();
            }
            set
            {
                SetSpriteBatch(value);
            }
        }


        #region Constructors

        public ScreenManager(Game game, GraphicsDeviceManager deviceManager) : base(game)
        {
            this.deviceManager = deviceManager;
            this.viewportStack = new Stack<Viewport>();
        }

        #endregion


        #region Screen Size Routines

        public void SetScreenSize(int width, int height, bool fullScreen)
        {
            this.deviceManager.PreferredBackBufferWidth = width;
            this.deviceManager.PreferredBackBufferHeight = height;
            this.deviceManager.IsFullScreen = fullScreen;
            this.deviceManager.ApplyChanges();
        }


        public void SetFullScreen(bool fullScreen)
        {
            this.deviceManager.IsFullScreen = fullScreen;
            this.deviceManager.ApplyChanges();
        }


        public void ToggleFullscreen()
        {
            this.deviceManager.IsFullScreen = !this.deviceManager.IsFullScreen;
            this.deviceManager.ApplyChanges();
        }

        #endregion


        #region Viewport Routines

        /// <summary>
        /// Pushes a new viewport onto the stack
        /// </summary>
        /// <param name="viewport"></param>
        
        public void PushViewport(Viewport viewport)
        {
            this.viewportStack.Push(this.deviceManager.GraphicsDevice.Viewport);
            this.deviceManager.GraphicsDevice.Viewport = viewport;
        }

        
        /// <summary>
        /// Pops the last viewport off of the stack
        /// </summary>
        
        public Viewport PopViewport()
        {
            if (this.viewportStack.Count > 0)
                this.deviceManager.GraphicsDevice.Viewport = this.viewportStack.Pop();

            return this.CurrentViewport;
        }


        /// <summary>
        /// Clears the viewport stack and sets the viewport
        /// </summary>
        /// <param name="viewport"></param>
        
        private void SetViewport(Viewport viewport)
        {
            this.viewportStack.Clear();
            this.viewportStack.Push(viewport);
            this.deviceManager.GraphicsDevice.Viewport = viewport;
        }

        #endregion


        #region SpriteBatch Routines

        /// <summary>
        /// Pushes a new spriteBatch onto the stack
        /// </summary>
        /// <param name="spriteBatch"></param>
        
        public void PushSpriteBatch(SpriteBatch spriteBatch)
        {
            this.spriteBatchStack.Push(spriteBatch);
        }

        
        /// <summary>
        /// Pops the last sprite batch off of the stack
        /// </summary>
        
        public SpriteBatch PopSpriteBatch()
        {
            if (this.spriteBatchStack.Count > 0)
                this.spriteBatchStack.Pop();

            return this.spriteBatchStack.Peek();
        }


        /// <summary>
        /// Clears the sprite batch stack and sets the sprite batch
        /// </summary>
        /// <param name="spriteBatch"></param>
        
        private void SetSpriteBatch(SpriteBatch spriteBatch)
        {
            this.spriteBatchStack.Clear();
            this.spriteBatchStack.Push(viewport);
        }

        #endregion

    }
}
