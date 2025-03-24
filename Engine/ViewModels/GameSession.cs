using Engine.Models;
using Engine.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.ViewModels
{
    public class GameSession
    {
        public World CurrentWorld { get; set; }
        public Player CurrentPlayer { get; set; }
        public Location CurrentLocation { get; set; }
        

        public GameSession()
        {
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "Kassandra";
            CurrentPlayer.CharacterClass = "Druid";
            CurrentPlayer.Hitpoints = 10;
            CurrentPlayer.Gold = 1000000;
            WorldFactory factory = new WorldFactory();
            CurrentWorld = factory.CreateWorld();
            CurrentLocation = CurrentWorld.LocationAt(-2, -1);
        }

    }
}
