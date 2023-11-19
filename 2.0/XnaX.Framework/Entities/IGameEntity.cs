using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics; 


namespace XnaX.Framework
{
    public interface IGameEntity : IUpdateable
    {
        EventHandler StateChanged;

        int State { get; set; }
    }
}