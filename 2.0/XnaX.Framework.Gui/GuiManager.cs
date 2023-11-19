using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace XnaX.Framework.Gui
{
    public class GuiManager : IGuiManager 
    {
        IInputHandler FocusControl { get; set; }


        #region IInputHandler Members

        public void ProcessInput(GameTime gameTime)
        {
            // Send input to the control with input focus
        }

        #endregion

    }
}
