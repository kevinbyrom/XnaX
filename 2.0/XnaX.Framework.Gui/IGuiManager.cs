using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace XnaX.Framework.Gui
{
    public interface IGuiManager : IInputHandler 
    {
        IInputHandler FocusControl { get; set; }


    }
}
