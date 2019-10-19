using System;
using System.Collections.Generic;
using TW_Assignment.Source.exceptions;

namespace TW_Assignment.Source.equalityProblem
{
    public class Player
    {
        public string Name { get; set; }
        public int JerseyNumber { get; set; }
        public Player(String name, int jerseyNumber)
        {
            this.Name = name;
            this.JerseyNumber = jerseyNumber;
        }
        public override bool Equals(object obj)
        {
            var item = obj as Player;

            if (item == null)
            {
                return false;
            }

            return this.Name.Equals(item.Name) && this.JerseyNumber.Equals(item.JerseyNumber);
        }
        public override int GetHashCode()
        {
            return this.JerseyNumber.GetHashCode();
        }


        public bool Equals(Player other)
        {
            return other.Equals(this);
        }
    }
}
