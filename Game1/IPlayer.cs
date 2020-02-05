using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game1 {
    public interface IPlayer
    {
        void SetPosition(int x, int y);
        Vector2 GetPosition();
        void SetState(IPlayerState state);

        IPlayerState GetState();
        void MoveUp();
        void MoveDown();
        void MoveLeft();
        void MoveRight();
        void Attack();
        void Update();
        void Draw(SpriteBatch spriteBatch);

    }
}