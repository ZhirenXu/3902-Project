using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace Game1
{
    public class Border
    {
        private int minX;
        private int minY;
        private int maxX;
        private int maxY;
        private int verticalDoorTopY;
        private int horizontalDoorLeftX;
        private int topWallDistance;
        private int doorWidth;
        private bool topOpen;
        private bool leftOpen;
        private bool rightOpen;
        private bool botOpen;

        public Border(GraphicsDeviceManager graphics)
        {
            topWallDistance = 60;
            doorWidth = 25;
            minX = graphics.GraphicsDevice.Viewport.X + topWallDistance+30;
            minY = graphics.GraphicsDevice.Viewport.X + topWallDistance;
            maxX = graphics.GraphicsDevice.Viewport.Width-topWallDistance*2-10;
            maxY = minY + graphics.GraphicsDevice.Viewport.Height - topWallDistance*3-12;
            verticalDoorTopY = graphics.GraphicsDevice.Viewport.Height / 2 - doorWidth / 2 - 20;
            horizontalDoorLeftX = graphics.GraphicsDevice.Viewport.Width / 2 - doorWidth / 2;
            rightOpen = true;
            topOpen = false;
            leftOpen = false;
            botOpen = false;
        }

        public void CheckCollision(ICollidable collidable)
        {
            if (collidable.GetHitBox().X < minX)
            {
                if ((leftOpen && !(collidable.GetHitBox().Y < verticalDoorTopY + doorWidth && collidable.GetHitBox().Y > verticalDoorTopY)) || !leftOpen)
                {
                    collidable.SetPosition(minX, collidable.GetHitBox().Y);
                    collidable.BorderCollision();
                }
            }
            if (collidable.GetHitBox().X > maxX)
            {
                if (rightOpen && collidable.GetHitBox().X > maxX + 10 && collidable.GetHitBox().Y < verticalDoorTopY)
                {
                    collidable.SetPosition(collidable.GetHitBox().X, verticalDoorTopY);
                    collidable.BorderCollision();
                }
                 else if ((rightOpen && collidable.GetHitBox().X < maxX + 10 && !(collidable.GetHitBox().Y < verticalDoorTopY + doorWidth && collidable.GetHitBox().Y > verticalDoorTopY)) || !rightOpen)
                {
                    collidable.SetPosition(maxX, collidable.GetHitBox().Y);
                    collidable.BorderCollision();
                }
          
            }
            if (collidable.GetHitBox().Y > maxY)
            {
                if ((botOpen && !(collidable.GetHitBox().X > horizontalDoorLeftX + doorWidth && collidable.GetHitBox().X < horizontalDoorLeftX)) || !botOpen)
                {
                    collidable.SetPosition(collidable.GetHitBox().X, maxY);
                    collidable.BorderCollision();
                }
            }
            if (collidable.GetHitBox().Y < minY)
            {
                if ((topOpen && !(collidable.GetHitBox().X > horizontalDoorLeftX + doorWidth && collidable.GetHitBox().X < horizontalDoorLeftX)) || !topOpen)
                {
                    collidable.SetPosition(collidable.GetHitBox().X, minY);
                    collidable.BorderCollision();
                }
            }
        }
    }
}
