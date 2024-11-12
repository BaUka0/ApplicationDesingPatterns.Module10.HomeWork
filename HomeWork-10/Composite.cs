using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_10
{
    public abstract class FileSystemComponent
    {
        protected string _name;
        public FileSystemComponent(string name)
        {
            _name = name;
        }

        public abstract int GetSize();
        public abstract void Display(int depth);
    }

    public class File : FileSystemComponent
    {
        private int _size;
        public File(int size, string name) : base(name)
        {
            _size = size;
        }
        public override int GetSize()
        {
            return _size;
        }
        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + " File: " + _name + ", size: " + GetSize() + "bytes");
        }
    }
    public class Directory : FileSystemComponent
    {
        private List<FileSystemComponent> _components;
        public Directory(string name) : base(name)
        {
            _components = new List<FileSystemComponent>();
        }
        public void Add(FileSystemComponent component)
        {
            _components.Add(component);
        }
        public void Remove(FileSystemComponent component)
        {
            _components.Remove(component);
        }
        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + " Directory: " + _name + ", size: " + GetSize() + "bytes");
            foreach (var component in _components)
            {
                component.Display(depth + 2);
            }

        }
        public override int GetSize()
        {
            int totalSize = 0;
            foreach (var component in _components)
            {
                totalSize += component.GetSize();
            }
            return totalSize;
        }
    }
    internal class Composite
    {
    }
}
