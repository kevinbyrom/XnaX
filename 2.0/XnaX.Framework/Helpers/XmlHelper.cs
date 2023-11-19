﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;



namespace XnaX.Framework.Helpers
{
    static public class XmlUtil
    {

        static public string GetNodeText(XmlNode node, string field, string defval)
        {
            if (node[field] != null)
                return node[field].InnerText;
            else
                return defval;
        }


        static public Rectangle GetNodeRectangle(XmlNode node)
        {
            int x, y, width, height;

            x       = Convert.ToInt32(GetNodeAttribute(node, "x", "0"));
            y       = Convert.ToInt32(GetNodeAttribute(node, "y", "0"));
            width   = Convert.ToInt32(GetNodeAttribute(node, "width", "0"));
            height  = Convert.ToInt32(GetNodeAttribute(node, "height", "0"));
            
            return new Rectangle(x, y, width, height);
        }


        static public Vector2 GetNodeVector2(XmlNode node)
        {
            Vector2 vector = new Vector2();

            vector.X = (float)Convert.ToDouble(GetNodeAttribute(node, "x", "0"));
            vector.Y = (float)Convert.ToDouble(GetNodeAttribute(node, "y", "0"));

            return vector;
        }


        static public Vector3 GetNodeVector3(XmlNode node)
        {
            Vector3 vector = new Vector3();

            vector.X = (float)Convert.ToDouble(GetNodeAttribute(node, "x", "0"));
            vector.Y = (float)Convert.ToDouble(GetNodeAttribute(node, "y", "0"));
            vector.Z = (float)Convert.ToDouble(GetNodeAttribute(node, "z", "0"));

            return vector;
        }


        static public Vector4 GetNodeVector4(XmlNode node)
        {
            Vector4 vector = new Vector4();

            vector.X = (float)Convert.ToDouble(GetNodeAttribute(node, "x", "0"));
            vector.Y = (float)Convert.ToDouble(GetNodeAttribute(node, "y", "0"));
            vector.Z = (float)Convert.ToDouble(GetNodeAttribute(node, "z", "0"));
            vector.W = (float)Convert.ToDouble(GetNodeAttribute(node, "w", "1"));

            return vector;
        }


        static public Color GetNodeColor(XmlNode node)
        {
            Vector4 vector = GetNodeVector4(node);

            return new Color(vector);
        }


        static public string GetNodeAttribute(XmlNode node, string attr, string defval)
        {
            if (node.Attributes[attr] != null)
                return node.Attributes[attr].InnerText;
            else
                return defval;
        }
    }
}
