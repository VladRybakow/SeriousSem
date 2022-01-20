using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeriousSem.Data
{
    public class LogicGrooping
    {
        public string name;
        public string surname;
        public int group;
        public string faculty;

        public LogicGrooping(string name, string surname, int group, string faculty)
        {
            this.name = name;
            this.surname = surname;
            this.group = group;
            this.faculty = faculty;
        }
        public static List<LogicGrooping> GetStudents()
        {
            List<LogicGrooping> list = new List<LogicGrooping>();

            list.Add(new LogicGrooping("Ivan", "Ivanov", 222, "Medical"));
            list.Add(new LogicGrooping("Bulat", "Bulov", 221, "Mathematical"));
            list.Add(new LogicGrooping("Iskander", "Iskov", 202, "Programmer"));
            list.Add(new LogicGrooping("Andrey", "Ibanov", 321, "Prison"));

            return list;
        }
    }
    public class LogicGames
    {
        public string name;
        public string date_of_manufacture;
        public int price;
        public string publisher;

        public LogicGames(string name, string date_of_manufacture, int price, string publisher)
        {
            this.name = name;
            this.date_of_manufacture = date_of_manufacture;
            this.price = price;
            this.publisher = publisher;
        }

        public static List<LogicGames> GetGames()
        {
            List<LogicGames> list = new List<LogicGames>();
            list.Add(new LogicGames("Minecraft", "2011 г.", 2000, "Mojang Studios"));
            list.Add(new LogicGames("Grand Theft Auto 5", "2013 г.", 760, " Rockstar Games"));
            list.Add(new LogicGames("Free Fire", "2017 г.", 0, "111dots Studio"));
            list.Add(new LogicGames("Far Cry 3", "2012 г.", 1200, "Ubisoft"));
            return list;
        }
    }

    public class LogicAuto
    {
        public string name;
        public string date_of_manufacture;
        public int price;
        public string manufacturer;

        public LogicAuto(string Name, string date_of_manufacture, int price, string manufacturer)
        {
            this.name = Name;
            this.date_of_manufacture = date_of_manufacture;
            this.price = price;
            this.manufacturer = manufacturer;
        }

        public static List<LogicAuto> GetAuto()
        {
            List<LogicAuto> list = new List<LogicAuto>();
            list.Add(new LogicAuto("Lada Granta", "2011", 600000, "АвтоВАЗ"));
            list.Add(new LogicAuto("Kia Rio", "2020", 1100000, "Kia Motors"));
            list.Add(new LogicAuto("Hyundai Creta", "2018", 1200000, "Hyundai Motor"));
            list.Add(new LogicAuto("Volkswagen Polo", "2021", 900000, "Volkswagen"));
            return list;
        }
    }
}
