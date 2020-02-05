using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game1 {
    public interface IPlayer
    {
        void setPosition(int x, int y);
        Vector2 getPosition();
        void changeState(IPlayerState state);

        IPlayerState getState();

    }
}