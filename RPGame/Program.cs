
using System;
class Hero
{
    public string Name;
    public string Sex;
    public string Rase;
    public string Class;
    public Dictionary<string, int> Skills = new Dictionary<string, int>()
    {

        {"Сила",0},
        {"Удача",0},
        {"Ловкость",0},
        {"Харизма",0},
        {"Эмпатия",0},
        {"Красноречие",0},

    };
}
class InRase
{
    public string Name;
    public string Ability;
    public string Bonus;
    public string Side;
    public Dictionary<string, int> Skills = new Dictionary<string, int>()
    {
        {"Сила",0},
        {"Удача",0},
        {"Ловкость",0},
        {"Харизма",0},
        {"Эмпатия",0},
        {"Красноречие",0},
    };
    public InRase(string name, string ability, string bonus, string side, Dictionary<string, int> skills)
    {
        Name = name;
        Ability = ability;
        Bonus = bonus;
        Side = side;
        Skills = skills;
    }
}
class Program
{
    public static InRase[] Rases =
    {
        new InRase("Люди", "Fire", "Intelect", "sw", new Dictionary<string, int>(){
            {"Сила",10},
            {"Удача",5},
            {"Ловкость",6},
            {"Харизма",5},
            {"Эмпатия",4},
            {"Красноречие",7},
        }),
        new InRase("Эльфы", "Fire", "Intelect", "sw", new Dictionary<string, int>(){
            {"Сила",10},
            {"Удача",5},
            {"Ловкость",6},
            {"Харизма",5},
            {"Эмпатия",4},
            {"Красноречие",7}
        }),
        new InRase("Гномы", "Fire", "Intelect", "sw", new Dictionary<string, int>(){
            {"Сила",10},
            {"Удача",5},
            {"Ловкость",6},
            {"Харизма",5},
            {"Эмпатия",4},
            {"Красноречие",7}
        }),
        new InRase("Орки", "Fire", "Intelect", "sw", new Dictionary<string, int>(){
            {"Сила",10},
            {"Удача",5},
            {"Ловкость",6},
            {"Харизма",5},
            {"Эмпатия",4},
            {"Красноречие",7}
        }),
        new InRase("Эльфы", "Fire", "Intelect", "sw", new Dictionary<string, int>(){
            {"Сила",10},
            {"Удача",5},
            {"Ловкость",6},
            {"Харизма",5},
            {"Эмпатия",4},
            {"Красноречие",7}
        }),
        new InRase("Гоблины", "Fire", "Intelect", "sw", new Dictionary<string, int>(){
            {"Сила",10},
            {"Удача",5},
            {"Ловкость",6},
            {"Харизма",5},
            {"Эмпатия",4},
            {"Красноречие",7}
        })
    };
    static void SelectRase(Hero myHero)
    {
        string[] nameRase = { "Люди", "Эльфы", "Орки", "Гоблины", "Гномы" }; //вводим строковый массив 5 элементов
        Console.WriteLine("Выберите расу героя: ");
        Select(nameRase);
        InRase RaseHero = Rases[Convert.ToInt32(Console.ReadLine()) - 1]; //RaseHero призваиваем значение//words конвертируем в численные значения для ввода с клавиатуры, вычитаем 1 для работы с массивом
        Console.WriteLine("Вы выбрали расу: " + RaseHero.Name);
        myHero.Rase = RaseHero.Name;
        myHero.Skills = RaseHero.Skills;
    }
    static void SelectSex(Hero myHero)
    {
        string[] nameSex = { "Мужской", "Женский" };
        Console.WriteLine("Выберите пол героя: ");
        Select(nameSex);
        string sexHero = nameSex[Convert.ToInt32(Console.ReadLine()) - 1];
        Console.WriteLine("Вы выбрали пол: " + sexHero);
        myHero.Sex = sexHero;
    }
    static void SelectClass(Hero myHero)
    {
        string[] nameClass = { "Воин", "Разбойник", "Маг", "Вор" };
        Console.WriteLine("Выберите класс героя: ");
        Select(nameClass);
        string classHero = nameClass[Convert.ToInt32(Console.ReadLine()) - 1];
        Console.WriteLine("Вы выбрали класс: " + classHero);
        myHero.Class = classHero;
    }


    static void Select(string[] words) //функция выбора.
    {
        for (int i = 0; i < words.Length - 1; i++)   //цикл от 0 до 4
        {
            Console.Write(i + 1 + " - " + words[i] + ", "); //вывод массива порядковый номер начиная с (0 + 1) //с наименованием расы words[i] и точку с запятой после каждого выведенного параметра.
        }
        Console.Write(words.Length + " - " + words[words.Length - 1] + "."); //ставим точку в конце.
        Console.WriteLine("");
    }

    static void Main(string[] args)
    {
        Hero myHero = new Hero();
        Console.WriteLine("Введите ваше имя: ");
        myHero.Name = Console.ReadLine();
        SelectRase(myHero);
        SelectSex(myHero);
        SelectClass(myHero);

        Console.WriteLine("Характеристики героя:");
        Console.WriteLine("Ваше имя: " + myHero.Name);
        Console.WriteLine("Ваш пол: " + myHero.Sex);
        Console.WriteLine("Ваша раса: " + myHero.Rase);
        Console.WriteLine("Ваш класс: " + myHero.Class);
        Console.WriteLine("Сила: " + myHero.Skills["Сила"]);
        Console.WriteLine("Удача: " + myHero.Skills["Удача"]);
        Console.WriteLine("Ловкость: " + myHero.Skills["Ловкость"]);
        Console.WriteLine("Харизма: " + myHero.Skills["Харизма"]);
        Console.WriteLine("Эмпатия: " + myHero.Skills["Эмпатия"]);
        Console.WriteLine("Красноречие: " + myHero.Skills["Красноречие"]);
        
    }
}
