using System;
using Xunit;

namespace Game.Tests
{
    public class PlayerCharacterShould
    {
        [Fact]
        public void WhenInexperienceWhenNew()
        {
            PlayerCharacter sut = new PlayerCharacter();
        }
    }
}
