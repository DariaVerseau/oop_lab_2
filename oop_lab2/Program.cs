using oop_lab2;

DataStructures dataStructures = new DataStructures();

            while (true)
            {
                //Меню выбора
                Console.WriteLine("\nМеню:");
                Console.WriteLine("1. Добавить круг");
                Console.WriteLine("2. Добавить прямоугольник");
                Console.WriteLine("3. Вывести информацию о фигурах");
                Console.WriteLine("4. Выйти из программы");
                Console.Write("Выберите действие: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": //Добавление круга
                        Console.Write("Введите радиус круга: ");
                        if (double.TryParse(Console.ReadLine(), out double radius))
                        {
                            dataStructures.AddShape(new Circle(radius));
                            Console.WriteLine("Круг добавлен.");
                        }
                        else
                        {
                            Console.WriteLine("Некорректный ввод.");
                        }
                        break;

                    case "2": //Добавление прямоугольника
                        Console.Write("Введите ширину прямоугольника: ");
                        if (double.TryParse(Console.ReadLine(), out double width))
                        {
                            Console.Write("Введите высоту прямоугольника: ");
                            if (double.TryParse(Console.ReadLine(), out double height))
                            {
                                dataStructures.AddShape(new Rectangle(width, height));
                                Console.WriteLine("Прямоугольник добавлен.");
                            }
                            else
                            {
                                Console.WriteLine("Некорректный ввод.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Некорректный ввод.");
                        }
                        break;

                    case "3":
                        Console.WriteLine("Введите: " +
                                          "\n1 - просмотр списка" +
                                          "\n2 - просмотр очереди" +
                                          "\n3 - просмотр стека");
                        int input = Convert.ToInt32(Console.ReadLine());
                        dataStructures.DisplayDataStructures(input);
                        break;

                    case "4": //Выход
                        return;

                    default:
                        Console.WriteLine("Некорректный выбор.");
                        break;
                }
            }
        