using Npgsql; 
using System;

class Program
{
    static NpgsqlConnection OpenConnection()
    {
        string connectionString = @"Host=10.30.0.137;Username=gr622_dghddgh;Password=voqgfhjkm;Database=gr622_dghddgh";
        NpgsqlConnection connection = new NpgsqlConnection(connectionString);
        connection.Open();
        return connection;
    }

    static void Main()
    {
        Console.WriteLine("Новый тип машины успешно добавлен в базу данных.");

        Console.WriteLine("Выберите действие:");
        Console.WriteLine("1. Добавить автомобиль"); 
        Console.WriteLine("2. Добавить тип"); 
        Console.WriteLine("3. Добавление водителя"); 
        Console.WriteLine("4. Добавление маршрута"); 
        Console.WriteLine("5. Добавление рейса "); //ошибка
        Console.WriteLine("6. Просмотр машин "); 
        Console.WriteLine("7. Просмотр типов "); 
        Console.WriteLine("8. Просмотр водителей "); 
        Console.WriteLine("9. Просмотр маршрута "); 
        Console.WriteLine("10. Просмотр рейса "); 
        Console.WriteLine("11. Просмотр Категории "); 
        Console.WriteLine("12. Добавление Категории "); //ошибка
        Console.WriteLine(" . Выход");
        Console.WriteLine(" ");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Car();
                break;
            case "2":
                Type();
                break;
            case "3":
                driver();
                break;
            case "4":
                itinerary();
                break;
            case "5":
                route();
                break;
            case "6":
                LookCar();
                break;
            case "7":
                LookType();
                break;
            case "8":
                LookDriver();
                break;
            case "9":
                LookItinerary();
                break;
            case "10":
                LookRoute();
                break;
            case "11":
                LookСategory();
                break;
            case "12":
                category();
                break;

            case " ":
                Console.WriteLine("Программа завершена.");
                break;
            default:
                Console.WriteLine("Неверный выбор.");
                break;

            
        }

        void Car()
        {
            Console.WriteLine("Введите ID типа машины:");
            int Id_type_car = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите название нового типа машины:");
            string Name = Console.ReadLine();

            Console.WriteLine("Введите состояние по 10 бальной шкале:");
            string Num = Console.ReadLine();

            Console.WriteLine("Введите вместимость пассажиров нового типа машины:");
            int capacity = int.Parse(Console.ReadLine());

            using (NpgsqlConnection connection = OpenConnection())
            {
                string query =
                    "INSERT INTO car (id_type_car, name, state_number, number_passengers) VALUES (@Id_type_car, @Name, @Num, @capacity)";
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id_type_car", Id_type_car);
                    command.Parameters.AddWithValue("@Name", Name);
                    command.Parameters.AddWithValue("@Num", Num);
                    command.Parameters.AddWithValue("@capacity", capacity);

                    command.ExecuteNonQuery();
                    Console.WriteLine("Новая машина успешно добавлен в базу данных.");
                }
            }
        }

    }
    
    static void Type()
    {
        Console.WriteLine("name:");
        string Name = Console.ReadLine();

        using (NpgsqlConnection connection = OpenConnection())
        {
            string query = "INSERT INTO type_car ( name) VALUES ( @Name)";
            using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Name", Name);

                command.ExecuteNonQuery();
                Console.WriteLine("Новый тип машины успешно добавлен в базу данных.");
            }
        }
    }

    static void driver()
    {
        Console.WriteLine("Имя:");
        string FirstName = Console.ReadLine();

        Console.WriteLine("Фамилия:");
        string LastName = Console.ReadLine();

        Console.Write("Введите дату рождения (yyyy.mm.dd): ");
        string birth = Console.ReadLine();
        DateTime.Parse(birth);
        using (NpgsqlConnection connection = OpenConnection())
        {
            string query =
                "INSERT INTO driver ( first_name, last_name, birthdate) VALUES ( @FirstName, @LastName, @birth )";
            using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@FirstName", FirstName);
                command.Parameters.AddWithValue("@LastName", LastName);
                command.Parameters.AddWithValue("@birth", DateTime.Parse(birth));

                command.ExecuteNonQuery();
                Console.WriteLine("Новый водитель успешно добавлен в базу данных.");
            }
        }
    }

    static void route()
    {
        Console.WriteLine("id Водителя:");
        int Id_driver = int.Parse(Console.ReadLine());

        Console.WriteLine("id Машины:");
        int Id_car = int.Parse(Console.ReadLine());

        Console.WriteLine("id кол-во пассажиров:");
        int Id_itinerary = int.Parse(Console.ReadLine());

        Console.WriteLine("id кол-во пассажиров:");
        int Number_passengers = int.Parse(Console.ReadLine());

        using (NpgsqlConnection connection = OpenConnection())
        {
            string query =
                "INSERT INTO route (id_driver, id_car, id_itinerary, number_passengers) VALUES ( @Id_driver, @Id_car, @Id_itinerary, @Number_passengers )";
            using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Id_driver", Id_driver);
                command.Parameters.AddWithValue("@Id_car", Id_car);
                command.Parameters.AddWithValue("@Id_itinerary", Id_itinerary);
                command.Parameters.AddWithValue("@Number_passengers", Number_passengers);

                command.ExecuteNonQuery();
                Console.WriteLine("Новый рейсы успешно добавлен в базу данных.");
            }
        }
    }
    static void category()
    {
        Console.WriteLine("id Водителя:");
        int Id_driver = int.Parse(Console.ReadLine());

        Console.WriteLine("id Машины:");
        int Id_rights_category = int.Parse(Console.ReadLine());
        

        using (NpgsqlConnection connection = OpenConnection())
        {
            string query = "INSERT INTO route (id_driver, id_rights_category) VALUES ( @Id_driver, @Id_rights_category)";
            using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Id_driver", Id_driver);
                command.Parameters.AddWithValue("@Id_rights_category", Id_rights_category);

                command.ExecuteNonQuery();
                Console.WriteLine("Новый рейсы успешно добавлен в базу данных.");
            }
        }
    }
    
    static void rights_category()
    {
        Console.WriteLine("name:");
        string Name = Console.ReadLine();

        using (NpgsqlConnection connection = OpenConnection())
        {
            string query = "INSERT INTO rights_category (name) VALUES (@Name)";
            using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Name", Name);

                command.ExecuteNonQuery();
                Console.WriteLine("Новый тип категории успешно добавлен в базу данных.");

            }
        }
    }

    static void itinerary()
    {
        Console.WriteLine("name:");
        string Name = Console.ReadLine();

        using (NpgsqlConnection connection = OpenConnection())
        {
            string query = "INSERT INTO itinerary (name) VALUES ( @Name)";
            using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Name", Name);

                command.ExecuteNonQuery();
                Console.WriteLine("Новый маршрут успешно добавлен в базу данных.");

            }
        }
    }
    
static void LookCar()
    {
        using (NpgsqlConnection connection = OpenConnection())
        {
            string query = "SELECT * FROM car"; 
            using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
            {
                using (NpgsqlDataReader reader = command.ExecuteReader())
                {
                    Console.WriteLine("Car View:");
                    while (reader.Read())
                    {
                        Console.WriteLine(
                            $"Name: {reader["name"]}, ID: {reader["id"]}, State Number: {reader["state_number"]}, Number of Passengers: {reader["number_passengers"]}");
                    }
                }
            }
        }
    }
    static void LookType()
    {
        using (NpgsqlConnection connection = OpenConnection())
        {
            string query = "SELECT * FROM type_car"; 
            using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
            {
                using (NpgsqlDataReader reader = command.ExecuteReader())
                {
                    Console.WriteLine("Car View:");
                    while (reader.Read())
                    {
                        Console.WriteLine(
                            $"Имя: {reader["name"]}, ID: {reader["id"]}");
                    }
                }
            }
        }
    }
    static void LookDriver()
    {
        using (NpgsqlConnection connection = OpenConnection())
        {
            string query = "SELECT * FROM driver"; 
            using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
            {
                using (NpgsqlDataReader reader = command.ExecuteReader())
                {
                    Console.WriteLine("Car View:");
                    while (reader.Read())
                    {
                        Console.WriteLine(
                            $"Имя: {reader["first_name"]}, Фамилия: {reader["last_name"]}, Дата рождения: {reader["birthdate"]} ID: {reader["id"]}");
                    }
                }
            }
        }
    }
    static void LookItinerary()
    {
        using (NpgsqlConnection connection = OpenConnection())
        {
            string query = "SELECT * FROM itinerary"; 
            using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
            {
                using (NpgsqlDataReader reader = command.ExecuteReader())
                {
                    Console.WriteLine("Car View:");
                    while (reader.Read())
                    {
                        Console.WriteLine(
                            $"Имя: {reader["name"]}, ID: {reader["id"]}");
                    }
                }
            }
        }
    }
    static void LookRoute()
    {
        using (NpgsqlConnection connection = OpenConnection())
        {
            string query = "SELECT * FROM route"; 
            using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
            {
                using (NpgsqlDataReader reader = command.ExecuteReader())
                {
                   
                    while (reader.Read())
                    {
                        Console.WriteLine(
                            $"ID: {reader["id"]}, ID Водителя: {reader["id_driver"]}, ID Машины: {reader["id_car"]}, ID Маршрута: {reader["id_itinerary"]}, Кол-во пассажиров: {reader["number_passengers"]}");
                    }
                }
            }
        }
    }
    static void LookСategory()
    {
        using (NpgsqlConnection connection = OpenConnection())
        {
            string query = "SELECT * FROM driver_rights_category"; 
            using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
            {
                using (NpgsqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(
                            $"ID Водителя: {reader["id_driver"]}, ID категории: {reader["id_rights_category"]}");
                    }
                }
            }
        }
    }
}
