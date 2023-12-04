using System;

namespace Game.Characters.Interface{
    public interface ICharacter{
        int score { get; set; }

        int NumSelect();
    }
}
