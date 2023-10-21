using System;
using System.ComponentModel.Design;
using System.Data;
using System.Text;
using static System.UnauthorizedAccessException;

internal class Program
{
    private static void Main(string[] args)
    {
        DateTime currentDate = default;
        while (true)
        {
            string[] form = { "круглый - 200 ", "квадратный - 300 ", "треугольный - 100 " };
            int[] formprice = { 200, 300, 100 };
            string[] sizes = { "маленький - 1000 ", "средний - 1500 ", "большой - 2000 " };
            int[] sizesprice = { 1000, 1500, 2000 };
            string[] vkys = { "шоколадный - 200 ", "ванильный - 300 ", "фруктовый - 400 " };
            int[] vkysprice = { 200, 300, 400 };
            string[] quantities = { "одна штука - 300 ", "две штуки - 600 ", "три штуки - 900 " };
            int[] quantitiesprice = { 300, 600, 900 };
            string[] glazes = { "шоколадная глазурь - 200 ", "сливочная глазурь - 300 ", "глазурь без сахара - 400 " };
            int[] glazesprice = { 200, 300, 400 };
            string[] decorations = { "украшен фруктами - 100 ", "шоколадные украшения - 200 ", "украшен цветами - 300 " };
            int[] decorationsprice = { 100, 200, 300 };

            string shape = string.Empty;
            int shapeprice = 0;
            string size = string.Empty;
            int sizeprice = 0;
            string flavor = string.Empty;
            int flavorprice = 0;
            string quantity = string.Empty;
            int quantityprice = 0;
            string glaze = string.Empty;
            int glazeprice = 0;
            string decoration = string.Empty;
            int decorationprice = 0;

            int currentMenu = 0;
            bool isSubMenu = false;

            while (true)
            {
                if (isSubMenu)
                {
                    switch (currentMenu)
                    {
                        case 0:
                            Console.WriteLine("Выберите форму торта:");
                            for (int i = 0; i < form.Length; i++)
                            {
                                if (shape == form[i])
                                    Console.Write("--> ");
                                else
                                    Console.Write(" ");
                                Console.WriteLine(form[i]);
                            }
                            break;
                        case 1:
                            Console.WriteLine("Выберите размер торта:");
                            for (int i = 0; i < sizes.Length; i++)
                            {
                                if (size == sizes[i])
                                    Console.Write("--> ");
                                else
                                    Console.Write(" ");
                                Console.WriteLine(sizes[i]);
                            }
                            break;
                        case 2:
                            Console.WriteLine("Выберите вкус торта:");
                            for (int i = 0; i < vkys.Length; i++)
                            {
                                if (flavor == vkys[i])
                                    Console.Write("--> ");
                                else
                                    Console.Write(" ");
                                Console.WriteLine(vkys[i]);
                            }
                            break;
                        case 3:
                            Console.WriteLine("Выберите количество коржей:");
                            for (int i = 0; i < quantities.Length; i++)
                            {
                                if (quantity == quantities[i])
                                    Console.Write("--> ");
                                else
                                    Console.Write(" ");
                                Console.WriteLine(quantities[i]);
                            }
                            break;
                        case 4:
                            Console.WriteLine("Выберите глазурь для торта:");
                            for (int i = 0; i < glazes.Length; i++)
                            {
                                if (glaze == glazes[i])
                                    Console.Write("--> ");
                                else
                                    Console.Write(" ");
                                Console.WriteLine(glazes[i]);
                            }
                            break;
                        case 5:
                            Console.WriteLine("Выберите декор для торта:");
                            for (int i = 0; i < decorations.Length; i++)
                            {
                                if (decoration == decorations[i])
                                    Console.Write("--> ");
                                else
                                    Console.Write(" ");
                                Console.WriteLine(decorations[i]);
                            }
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Выберите параметры торта:");
                    for (int i = 0; i < 7; i++)
                    {
                        if (currentMenu == i)
                            Console.Write("--> ");
                        else
                            Console.Write(" ");

                        switch (i)
                        {
                            case 0:
                                Console.WriteLine("Форма торта");
                                break;
                            case 1:
                                Console.WriteLine("Размер торта");
                                break;
                            case 2:
                                Console.WriteLine("Вкус торта");
                                break;
                            case 3:
                                Console.WriteLine("Количество коржей");
                                break;
                            case 4:
                                Console.WriteLine("Глазурь");
                                break;
                            case 5:
                                Console.WriteLine("Декор");
                                break;
                            case 6:
                                Console.WriteLine("Нажмите Esc чтобы завершить заказ");
                                break;
                        }
                    }

                    Console.WriteLine("Ваш торт: " + shape + size + flavor + quantity + glaze + decoration);
                    int itog = shapeprice + sizeprice + flavorprice + quantityprice + glazeprice + decorationprice;
                    Console.WriteLine("Итоговая цена:" + itog);
                }

                ConsoleKeyInfo key = Console.ReadKey();

                if (isSubMenu)
                {
                    switch (currentMenu)
                    {
                        case 0:
                            if (key.Key == ConsoleKey.Escape)
                            {
                                isSubMenu = false;
                            }
                            if (key.Key == ConsoleKey.UpArrow)
                            {
                                int index = Array.IndexOf(form, shape);
                                shape = form[(index - 1 + form.Length) % form.Length];
                                shapeprice = formprice[(index - 1 + formprice.Length) % formprice.Length];
                            }
                            else if (key.Key == ConsoleKey.DownArrow)
                            {
                                int index = Array.IndexOf(form, shape);
                                shape = form[(index + 1) % form.Length];
                                shapeprice = formprice[(index + 1) % formprice.Length];
                            }
                            else if (key.Key == ConsoleKey.Enter)
                            {
                                isSubMenu = false;
                            }
                            Console.Clear();
                            break;
                        case 1:
                            if (key.Key == ConsoleKey.Escape)
                            {
                                isSubMenu = false;
                            }
                            if (key.Key == ConsoleKey.UpArrow)
                            {
                                int index = Array.IndexOf(sizes, size);
                                size = sizes[(index - 1 + sizes.Length) % sizes.Length];
                                sizeprice = sizesprice[(index - 1 + sizesprice.Length) % sizesprice.Length];
                            }
                            else if (key.Key == ConsoleKey.DownArrow)
                            {
                                int index = Array.IndexOf(sizes, size);
                                size = sizes[(index + 1) % sizes.Length];
                                sizeprice = sizesprice[(index + 1) % sizesprice.Length];
                            }
                            else if (key.Key == ConsoleKey.Enter)
                            {
                                isSubMenu = false;
                            }
                            Console.Clear();
                            break;
                        case 2:
                            if (key.Key == ConsoleKey.Escape)
                            {
                                isSubMenu = false;
                            }
                            if (key.Key == ConsoleKey.UpArrow)
                            {
                                int index = Array.IndexOf(vkys, flavor);
                                flavor = vkys[(index - 1 + vkys.Length) % vkys.Length];
                                flavorprice = vkysprice[(index - 1 + vkysprice.Length) % vkysprice.Length];
                            }
                            else if (key.Key == ConsoleKey.DownArrow)
                            {
                                int index = Array.IndexOf(vkys, flavor);
                                flavor = vkys[(index + 1) % vkys.Length];
                                flavorprice = vkysprice[(index + 1) % vkysprice.Length];
                            }
                            else if (key.Key == ConsoleKey.Enter)
                            {
                                isSubMenu = false;
                            }
                            Console.Clear();
                            break;
                        case 3:
                            if (key.Key == ConsoleKey.Escape)
                            {
                                isSubMenu = false;
                            }
                            if (key.Key == ConsoleKey.UpArrow)
                            {
                                int index = Array.IndexOf(quantities, quantity);
                                quantity = quantities[(index - 1 + quantities.Length) % quantities.Length];
                                quantityprice = quantitiesprice[(index - 1 + quantitiesprice.Length) % quantitiesprice.Length];
                            }
                            else if (key.Key == ConsoleKey.DownArrow)
                            {
                                int index = Array.IndexOf(quantities, quantity);
                                quantity = quantities[(index + 1) % quantities.Length];
                                quantityprice = quantitiesprice[(index + 1) % quantitiesprice.Length];
                            }
                            else if (key.Key == ConsoleKey.Enter)
                            {
                                isSubMenu = false;
                            }
                            Console.Clear();
                            break;
                        case 4:
                            if (key.Key == ConsoleKey.Escape)
                            {
                                isSubMenu = false;
                            }
                            if (key.Key == ConsoleKey.UpArrow)
                            {
                                int index = Array.IndexOf(glazes, glaze);
                                glaze = glazes[(index - 1 + glazes.Length) % glazes.Length];
                                glazeprice = glazesprice[(index - 1 + glazes.Length) % glazesprice.Length];
                            }
                            else if (key.Key == ConsoleKey.DownArrow)
                            {
                                int index = Array.IndexOf(glazes, glaze);
                                glaze = glazes[(index + 1) % glazes.Length];
                                glazeprice = glazesprice[(index + 1) % glazesprice.Length];
                            }
                            else if (key.Key == ConsoleKey.Enter)
                            {
                                isSubMenu = false;
                            }
                            Console.Clear();
                            break;
                        case 5:
                            if (key.Key == ConsoleKey.Escape)
                            {
                                isSubMenu = false;
                            }
                            if (key.Key == ConsoleKey.UpArrow)
                            {
                                int index = Array.IndexOf(decorations, decoration);
                                decoration = decorations[(index - 1 + decorations.Length) % decorations.Length];
                                decorationprice = decorationsprice[(index - 1 + decorationsprice.Length) % decorationsprice.Length];
                            }
                            else if (key.Key == ConsoleKey.DownArrow)
                            {
                                int index = Array.IndexOf(decorations, decoration);
                                decoration = decorations[(index + 1) % decorations.Length];
                                decorationprice = decorationsprice[(index + 1) % decorationsprice.Length];
                            }
                            else if (key.Key == ConsoleKey.Enter)
                            {
                                isSubMenu = false;
                            }
                            Console.Clear();
                            break;
                    }
                }
                else
                {
                    if (key.Key == ConsoleKey.UpArrow)
                    {
                        currentMenu = (currentMenu - 1 + 6) % 6;
                    }
                    else if (key.Key == ConsoleKey.DownArrow)
                    {
                        currentMenu = (currentMenu + 1) % 6;
                    }
                    else if (key.Key == ConsoleKey.Enter)
                    {
                        isSubMenu = true;
                    }
                    else if (key.Key == ConsoleKey.Escape)
                    {
                        int itog = shapeprice + sizeprice + flavorprice + quantityprice + glazeprice + decorationprice;
                        currentDate = DateTime.Now;
                        string txt = currentDate.ToString();
                        string txt1 = "Ваш торт: " + shape + size + flavor + quantity + glaze + decoration;
                        string txt2 = "Итоговая цена:" + itog;
                        string a = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Заказаный торт.txt";
                        File.AppendAllText(a, "\n" + txt);
                        File.AppendAllText(a, "\n" + txt1);
                        File.AppendAllText(a, "\n" + txt2);
                        Console.Clear();
                        break;
                    }
                    Console.Clear();
                }
            }
        }
    }
}