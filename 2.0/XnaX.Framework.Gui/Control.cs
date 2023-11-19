using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XnaX.Framework;
using XnaX.Framework.Graphics;


namespace XnaX.Framework.Gui
{
    public abstract class Control : ScreenElement, IInputHandler 
    {
        public IGuiManager GuiManager { get; set; }

        virtual void ProcessInput(GameTime gameTime)
        {
        }
    }
}
