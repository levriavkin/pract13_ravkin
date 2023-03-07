using System;
using System.Collections;

namespace prakt13
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ArrayList list = new ArrayList();
                list.Add(4.5);
                list.Add(18);
                list.AddRange(new string[] { "Студент", "Петров" });
                int c = list.Count;
                Console.WriteLine("Всего элементов коллекции - " + c);

                Console.WriteLine("С какого элемента в коллекции вы хотите вставлять?");
                int count = int.Parse(Console.ReadLine());
                if (count < c)
                {
                    if (count >= 0)
                    {
                        Console.WriteLine("Введите количество элементов коллекции");
                        int k = int.Parse(Console.ReadLine());
                        if (k >= 0)
                        {
                            ArrayList list2 = new ArrayList();
                            for (int i = 0; i < k; i++)
                            {
                                list2.Add(Console.ReadLine());
                            }
                            Console.WriteLine("--- LIST2 ---");
                            foreach (object e in list2)
                            {
                                Console.WriteLine(e);
                            }
                            list.InsertRange(count - 1, list2);
                            Console.WriteLine("Измененный LIST");
                            foreach (object e in list)
                            {
                                Console.WriteLine(e);
                            }

                            Console.WriteLine("Сколько элементов вы хотите удалить?");
                            int delete = int.Parse(Console.ReadLine());
                            if (delete < c)
                            {
                                if (delete >= 0)
                                {
                                    int c1 = list.Count;
                                    Console.WriteLine("Всего элементов коллекции - " + c1);
                                    Console.WriteLine("С какого элемента вы хотите удалять?");
                                    int delElem = int.Parse(Console.ReadLine());
                                    if (delElem < c1)
                                    {
                                        if (delElem >= 0)
                                        {
                                            list.RemoveRange(delElem - 1, delete);
                                            Console.WriteLine("Измененный LIST");
                                            foreach (object e in list)
                                            {
                                                Console.WriteLine(e);
                                            }
                                        }
                                        else { Console.WriteLine("Не может быть меньше 0"); }
                                    }
                                    else { Console.WriteLine("Нельзя вставлять с такого элемента"); }
                                }
                                else { Console.WriteLine("Не может быть меньше 0"); }

                            }
                            else { Console.WriteLine("Нельзя вставлять с такого элемента"); }

                        }
                        else { Console.WriteLine("Не может быть меньше 0"); }

                    }
                    else { Console.WriteLine("Не может быть меньше 0"); }
                }
                else { Console.WriteLine("Нельзя вставлять с такого элемента"); }
            }
            catch
            {
                Console.WriteLine("Неверный ввод");
            }












































                //ArrayList list = new ArrayList();
                //list.Add(4.5);
                //list.Add(18);
                //list.AddRange(new string[] { "Студент", "Петров" });
                //int c = list.Count;
                //Console.WriteLine("Всего элементов коллекции - " + c);

                //Console.WriteLine("С какого элемента в коллекции вы хотите вставлять?");
                //int count = int.Parse(Console.ReadLine());
                //if (count < c)
                //{
                //    if (count >= 0)
                //    {
                //        Console.WriteLine("Введите количество элементов коллекции");
                //        int k = int.Parse(Console.ReadLine());
                //        if (k >= 0)
                //        {

                //        }
                //        ArrayList list2 = new ArrayList();
                //        for (int i = 0; i < k; i++)
                //        {
                //            list2.Add(Console.ReadLine());
                //        }
                //        //list.AddRange(list2);
                //        Console.WriteLine("--- LIST2 ---");
                //        foreach (object e in list2)
                //        {
                //            Console.WriteLine(e);
                //        }
                //        list.InsertRange(count - 1, list2);
                //        Console.WriteLine("Измененный LIST");
                //        foreach (object e in list)
                //        {
                //            Console.WriteLine(e);
                //        }
                //        Console.WriteLine("Сколько элементов вы хотите удалить?");
                //        int delete = int.Parse(Console.ReadLine());
                //        if (delete < c)
                //        {
                //            if (delete >= 0)
                //            {
                //                Console.WriteLine("С какого элемента вы хотите удалять?");
                //                int delElem = int.Parse(Console.ReadLine());
                //                list.RemoveRange(delElem - 1, delete);
                //                Console.WriteLine("Измененный LIST");
                //                foreach (object e in list)
                //                {
                //                    Console.WriteLine(e);
                //                }
                //            }
                //            else { Console.WriteLine("Не может быть меньше 0"); }

                //        }
                //        else { Console.WriteLine("Нельзя вставлять с такого элемента"); }

                //    }
                //    else { Console.WriteLine("Не может быть меньше 0"); }
                //}
                //else { Console.WriteLine("Нельзя вставлять с такого элемента"); }

            }
    }
    }

