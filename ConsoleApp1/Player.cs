using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Player
    {
        private string _name="miura";
        private int _age=19;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello,World!");
            Console.WriteLine("Hello,Hellomaru.");
            Console.ReadLine();
        }

        private void CreatePlayer(string name,int age)
        {
            Player player = new Player();
            player._name = name;
            player._age = age;

            Console.WriteLine(name + " " + player._age);

            return;
        }

        private void ShowPlayer() 
        {
            CreatePlayer(_name, _age);

            Console.WriteLine(_name);
            Console.WriteLine(_age);
            ShowPlayer();
        }
    }
}
