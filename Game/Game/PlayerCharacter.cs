using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    public class PlayerCharacter
    {
        private int _health = 100;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string NickName { get; set; }
        public int Health { get => _health; }
    }
}
