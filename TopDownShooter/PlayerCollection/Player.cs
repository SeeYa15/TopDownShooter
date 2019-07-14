using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;

namespace TopDownShooter
{
    class Player : Entity
    {
        public Player(Texture2D texture)
        {
            Sprite = texture;
        }
    }
}
