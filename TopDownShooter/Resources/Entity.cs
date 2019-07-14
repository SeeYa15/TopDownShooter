using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopDownShooter
{
    abstract class Entity
    {
        public Vector2 Position { get; set; }
        public Texture2D Sprite { get; private set; }
        public void Draw()
        {

        }

        public void Update()
        {

        }
    }
}
