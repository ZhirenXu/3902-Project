﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game1.EnemySprites
{
    class GoriyaUp : ISprite
    {
        Texture2D texture;
        IEnemy enemy;
        int srcWidth = 16;
        int srcHeight = 16;
        int destWidth = 13;
        int destHeight = 13;
        int srcX = 239; /*Change this*/
        int srcY = 11;  /*and this*/


        public GoriyaUp(IEnemy enemy, Texture2D texture)
        {
            this.texture = texture;
            this.enemy = enemy;
            this.destWidth *= enemy.Size;
            this.destHeight *= enemy.Size;
        }
        public void Update()
        {

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle destRec = new Rectangle((int)enemy.GetPosition().X, (int)enemy.GetPosition().Y, destWidth, destHeight);
            Rectangle srcRec;
            srcRec = new Rectangle(srcX, srcY, srcWidth, srcHeight);
            spriteBatch.Begin();
            spriteBatch.Draw(texture, destRec, srcRec, Color.White);
            spriteBatch.End();
        }
    }
}
