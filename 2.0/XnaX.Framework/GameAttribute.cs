using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using Microsoft.Xna.Framework;

 
namespace XnaX.Framework
{

    public enum GameAttributeModifierType
    {
        Add         = 0,
        Multiply    = 1
    }


    public class Ranged<T> : ICloneable 
    {
        
        
        #region Properties

        protected float val;
        public float Val
        {
            get
            {
                switch (GameAttrModType)
                {           
                    case GameAttrModType.Multiply:
                        return val * modifier;
                
                    case GameAttrModType.Add:
                    default:
                        return val + modifier;
                }
            }
            set
            {
                val = MathHelper.Clamp(value, min, max);
            }
        }


        protected float min;
        public float Min
        {
            get
            {
                return min;
            }
        }


        protected float max;
        public float Max
        {
            get
            {
                return max;
            }
        }


        protected float modifier;
        public float Modifier
        {
            get
            {
                return modifier;
            }
        }


        protected GameAttributeModifierType modifierType;
        public GameAttributeModifierType ModifierType
        {
            get
            {
                return modifierType;
            }
        }

        protected DateTime modifierTime;
        public DateTime ModifierTime
        {
            get
            {
                return modifierTime;
            }
        }

        #endregion


        #region Constructors

        public GameAttribute()
        {
            this.val            = 0f;
            this.min            = 0f;
            this.max            = 1f;
            this.modifier       = 0f;
            this.modifierType   = GameAttributeModifierType.Add;
            this.modifierTime   = DateTime.Now;
        }
        
        public GameAttribute(float min, float max) : this()
        {
            this.min = min;
            this.max = max;
        }

        public GameAttribute(float val, float min, float max) : this(min, max)
        {
            this.val = val;
        }

        #endregion


        public void SetModifier(float modifier, GameAttributeModifierType modifierType)
        {
            this.modifier       = modifier;
            this.modifierType   = modifierType;
            this.modifierTime   = DateTime.Now;
        }


        #region ICloneable

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        #endregion

    }
}
