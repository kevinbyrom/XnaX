using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;



namespace XnaX.Framework.Graphics
{
    [Serializable]
    public class ScreenElement : DrawableGameComponent, IScreenEntity
    {
        public EventHandler OriginChanged;
        public EventHandler PositionChanged;
        public EventHandler SizeChanged;
        public EventHandler RotationChanged;
        public EventHandler ScaleChanged;
        public EventHandler DepthChanged;
        public EventHandler ColorChanged;
        public EventHandler VisibilityChanged;
        
        
        #region Properties
                
        public IScreenManager ScreenManager { get; set; }

        protected Vector2 origin;
        public Vector2 Origin
        {
            get
            {
                return this.origin;
            }
            set
            {
                if (this.origin != value)
                {
                    this.origin = value;
                    OnOriginChanged();
                }
            }
        }
        

        protected Vector2 position;
        public Vector2 Position
        {
            get
            {
                return this.position;
            }
            set
            {
                if (this.position != value)
                {
                    this.position = value;
                    OnPositionChanged();
                }
            }
        }


        protected Vector2 size;
        public Vector2 Size
        {
            get
            {
                return this.size;
            }
            set
            {
                if (this.size != value)
                {
                    this.size = value;
                    OnSizeChanged();
                }
            }
        }


        protected float rotation;
        public float Rotation
        {
            get
            {
                return this.rotation;
            }
            set
            {
                if (this.rotation != value)
                {
                    this.rotation = value;
                    OnRotationChanged();
                }
            }
        }


        protected float scale;
        public float Scale
        {
            get
            {
                return this.scale;
            }
            set
            {
                if (this.scale != value)
                {
                    this.scale = value;
                    OnScaleChanged();
                }
            }
        }


        protected float depth;
        public float Depth
        {
            get
            {
                return this.depth;
            }
            set
            {
                if (this.depth != value)
                {
                    this.depth = value;
                    OnDepthChanged();
                }
            }
        }


        protected Color color;
        public Color Color
        {
            get
            {
                return this.color;
            }
            set
            {
                if (this.color != value)
                {
                    this.color = value;
                    OnColorChanged();
                }
            }
        }


        protected bool isVisible;
        public bool IsVisible
        {
            get
            {
                return this.isVisible;
            }
            set
            {
                if (this.isVisible != value)
                {
                    this.isVisible = value;
                    OnVisibilityChanged();
                }
            }
        }

        #endregion


        #region Constructors

        public ScreenElement(Game game) : base(game)
        {
            this.position   = Vector2.Zero;
            this.isVisible  = true;

            this.ScreenManager = (IScreenManager)game.Services.GetService(typeof(IScreenManager));
        }

        #endregion
        

        #region Draw Routines

        public virtual void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
        }

        #endregion

        
        #region Change Handlers

        /// <summary>
        /// Handles origin changes
        /// </summary>
        
        protected virtual void OnOriginChanged()
        {

            // Raise the event
   
            if (this.OriginChanged != null)
                this.OriginChanged(this, null);

        }


        /// <summary>
        /// Handles position changes
        /// </summary>

        protected virtual void OnPositionChanged()
        {

            // Raise the event
   
            if (this.PositionChanged != null)
                this.PositionChanged(this, null);

        }


        /// <summary>
        /// Handles size changes
        /// </summary>
        
        protected virtual void OnSizeChanged()
        {

            // Raise the event
   
            if (this.SizeChanged != null)
                this.SizeChanged(this, null);

        }



        /// <summary>
        /// Handles rotation changes
        /// </summary>
        
        protected virtual void OnRotationChanged()
        {

            // Raise the event
   
            if (this.RotationChanged != null)
                this.RotationChanged(this, null);

        }



        /// <summary>
        /// Handles scale changes
        /// </summary>
        
        protected virtual void OnScaleChanged()
        {

            // Raise the event
   
            if (this.ScaleChanged != null)
                this.ScaleChanged(this, null);

        }



        /// <summary>
        /// Handles depth changes
        /// </summary>
        
        protected virtual void OnDepthChanged()
        {

            // Raise the event
   
            if (this.DepthChanged != null)
                this.DepthChanged(this, null);

        }



        /// <summary>
        /// Handles color changes
        /// </summary>
        
        protected virtual void OnColorChanged()
        {

            // Raise the event
   
            if (this.ColorChanged != null)
                this.ColorChanged(this, null);

        }
        


        /// <summary>
        /// Handles visibility changes
        /// </summary>
        
        protected virtual void OnVisibilityChanged()
        {

            // Raise the event
   
            if (this.VisibilityChanged != null)
                this.VisibilityChanged(this, null);

        }

        #endregion

    }
}
