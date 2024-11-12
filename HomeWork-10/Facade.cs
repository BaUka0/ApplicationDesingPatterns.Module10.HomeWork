using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_10
{
    public class TV
    {
        public void TurnOn()
        {
            Console.WriteLine("TV is turned on.");
        }
        public void SetChannel(int channel)
        {
            Console.WriteLine($"TV channel is set to {channel}.");
        }
        public void TurnOff()
        {
            Console.WriteLine("TV is turned off.");
        }
    }
    public class AudioSystem
    {
        public void TurnOn()
        {
            Console.WriteLine("Audio system is turned on.");
        }

        public void SetVolume(int level)
        {
            Console.WriteLine($"Audio volume is set to {level}.");
        }

        public void TurnOff()
        {
            Console.WriteLine("Audio system is turned off.");
        }
    }
    public class DVDPlayer
    {
        public void Play()
        {
            Console.WriteLine("DVD player is playing.");
        }

        public void Pause()
        {
            Console.WriteLine("DVD player is paused.");
        }

        public void Stop()
        {
            Console.WriteLine("DVD player is stopped.");
        }
    }
    public class GameConsole
    {
        public void TurnOn()
        {
            Console.WriteLine("Game console is turned on.");
        }

        public void StartGame()
        {
            Console.WriteLine("Game console is starting a game.");
        }
        public void TurnOff()
        {
            Console.WriteLine("Game console is turned off.");
        }
    }
    public class HomeTheaterFacade
    {
        private TV _tv;
        private AudioSystem _audioSystem;
        private DVDPlayer _dvdPlayer;
        private GameConsole _gameConsole;

        public HomeTheaterFacade(TV tv, AudioSystem audioSystem, DVDPlayer dvdPlayer, GameConsole gameConsole)
        {
            _tv = tv;
            _audioSystem = audioSystem;
            _dvdPlayer = dvdPlayer;
            _gameConsole = gameConsole;
        }

        public void WatchMovie()
        {
            Console.WriteLine("Getting ready to watch a movie...");
            _tv.TurnOn();
            _tv.SetChannel(1);
            _audioSystem.TurnOn();
            _audioSystem.SetVolume(5);
            _dvdPlayer.Play();
        }

        public void TurnOff()
        {
            Console.WriteLine("Turning off the system...");
            _tv.TurnOff();
            _audioSystem.TurnOff();
            _dvdPlayer.Stop();
            _gameConsole.TurnOff();
        }

        public void StartGame()
        {
            Console.WriteLine("Getting ready to play a game...");
            _gameConsole.TurnOn();
            _gameConsole.StartGame();
        }

        public void ListenToMusic()
        {
            Console.WriteLine("Getting ready to listen to music...");
            _tv.TurnOn();
            _tv.SetChannel(2);
            _audioSystem.TurnOn();
            _audioSystem.SetVolume(7);
        }

        public void SetVolume(int volume)
        {
            Console.WriteLine("Setting volume to " + volume + "...");
            _audioSystem.SetVolume(volume);
        }
    }
    internal class Facade
    {
    }
}
