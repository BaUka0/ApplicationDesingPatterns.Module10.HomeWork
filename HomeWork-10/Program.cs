using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_10
{
    public class Program
    {
        static void Main(string[] args)
        {
            Directory rootDir = new Directory("Root");

            Directory dir1 = new Directory("Dir1");
            rootDir.Add(dir1);

            Directory dir2 = new Directory("Dir2");
            rootDir.Add(dir2);

            File file1 = new File(10, "File1");
            dir1.Add(file1);

            File file2 = new File(20, "File2");
            dir1.Add(file2);

            File file3 = new File(30, "File3");
            dir2.Add(file3);

            
            Console.WriteLine("File System:");
            rootDir.Display(1);

            TV tv = new TV();
            AudioSystem audioSystem = new AudioSystem();
            DVDPlayer dvdPlayer = new DVDPlayer();
            GameConsole gameConsole = new GameConsole();

            HomeTheaterFacade facade = new HomeTheaterFacade(tv, audioSystem, dvdPlayer, gameConsole);

            facade.WatchMovie();

            facade.ListenToMusic();

            facade.SetVolume(10);

            facade.StartGame();

            facade.TurnOff();
        }
    }
}
