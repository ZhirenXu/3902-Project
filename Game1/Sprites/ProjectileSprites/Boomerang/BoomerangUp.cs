﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Game1.PlayerStates;
using System;

namespace Game1.ProjectileSprites
{
    class BoomerangUp : ISprite
    {
        Texture2D texture;
        IProjectile projectile;
        int boomSrcWidth = 5;
        int boomSrcHeight = 10;
        int boomDestWidth = 5;
        int boomDestHeight = 10;
        int boomSrcX = 0;
        int boomSrcY = 111;
        int speed;
        float rotation;
        float velocity = 25f;

        public BoomerangUp(IProjectile projectile, Texture2D texture)
        {
            this.texture = texture;
            this.projectile = projectile;
            this.boomDestWidth *= projectile.Size;
            this.boomDestHeight *= projectile.Size;
            this.speed = projectile.Speed;
        }
        public void Update()
        {
            rotation += MathHelper.ToRadians(velocity);
            int projX = (int)projectile.GetPosition().X;
            int projY = (int)projectile.GetPosition().Y;
            projY -= speed;
            projectile.SetPosition(projX, projY);
            projectile.ShotDistance += speed;
        }

        public void Draw(SpriteBatch spriteBatch)
        { 
            Rectangle boomSrcRec = new Rectangle(boomSrcX, boomSrcY, boomSrcWidth, boomSrcHeight);
            Rectangle boomDestRec = new Rectangle((int)projectile.GetPosition().X+15, (int)projectile.GetPosition().Y+15, boomDestWidth, boomDestHeight);
            spriteBatch.Begin();
            spriteBatch.Draw(texture, boomDestRec, boomSrcRec, Color.White, rotation, new Vector2(3,5),SpriteEffects.None,0); //gotta play around with origin vector due to rotation
            spriteBatch.End();
        }
    }
}
