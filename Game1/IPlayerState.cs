using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    public interface IPlayerState
    {
        void UpArrow();
        void DownArrow();
        void LeftArrow();
        void RightArrow();

    }
}
