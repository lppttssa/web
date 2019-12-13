using System;

namespace Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string mode = "o";
            while (mode != "exit")
            {
                Console.Write("Choose your mode: Manager, Searcher, Buyer, Bank or exit: ");
                mode = Console.ReadLine();
                Console.WriteLine();
                if (mode == "Manager")
                {
                    string chosen = "o";
                    while (chosen != "exit")
                    {
                        Console.Write("Choose your Manager mode: CityManager, CompanyManager, PilotManager, TicketManager or exit: ");
                        chosen = Console.ReadLine();
                        Console.WriteLine();
                        if (chosen == "CityManager")
                        {
                            string action = "n";
                            while (action != "exit")
                            {
                                Console.Write("Choose your action: Add, Change, Delete, GetAll, GetById or exit: ");
                                action = Console.ReadLine();
                                if (action == "Add")
                                {
                                    Console.Write("Write city id: ");
                                    string id = Console.ReadLine();
                                    Console.Write("Write city name: ");
                                    string name = Console.ReadLine();
                                    try
                                    {
                                        int i_id = Convert.ToInt32(id);
                                        CityManager.Add(i_id, name);
                                        Console.WriteLine();
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Sorry! Wrong parameters!");
                                        Console.WriteLine();
                                    }

                                }
                                else if (action == "Change")
                                {
                                    Console.Write("Write city id: ");
                                    string id = Console.ReadLine();
                                    Console.Write("Write new city id: ");
                                    string new_id = Console.ReadLine();
                                    try
                                    {
                                        int i_id = Convert.ToInt32(id);
                                        int inew_id = Convert.ToInt32(new_id);
                                        CityManager.Change(i_id, inew_id);
                                        Console.WriteLine();
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Sorry! Wrong parameters!");
                                        Console.WriteLine();
                                    }
                                }
                                else if (action == "Delete")
                                {
                                    Console.Write("Write city id: ");
                                    string id = Console.ReadLine();
                                    try
                                    {
                                        int i_id = Convert.ToInt32(id);
                                        CityManager.Delete(i_id);
                                        Console.WriteLine();
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Sorry! Wrong parameters!");
                                        Console.WriteLine();
                                    }
                                }
                                else if (action == "GetAll")
                                {
                                    CityManager.GetAll();
                                    Console.WriteLine();
                                }
                                else if (action == "GetById")
                                {
                                    Console.Write("Write city id: ");
                                    string id = Console.ReadLine();
                                    try
                                    {
                                        int i_id = Convert.ToInt32(id);
                                        CityManager.GetById(i_id);
                                        Console.WriteLine();
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Sorry! Wrong parameters!");
                                        Console.WriteLine();
                                    }
                                }
                                else if (action == "exit")
                                {
                                    Console.WriteLine();
                                }
                                else
                                {
                                    Console.WriteLine("No matched action!");
                                }
                            }
                        }
                        else if (chosen == "CompanyManager")
                        {
                            string action = "n";
                            while (action != "exit")
                            {
                                Console.Write("Choose your action: Add, ChangeId, ChangeName, Delete, GetAll, GetById or exit: ");
                                action = Console.ReadLine();
                                if (action == "Add")
                                {
                                    Console.Write("Write company id: ");
                                    string id = Console.ReadLine();
                                    Console.Write("Write company name: ");
                                    string name = Console.ReadLine();
                                    try
                                    {
                                        int i_id = Convert.ToInt32(id);
                                        CompanyManager.Add(i_id, name);
                                        Console.WriteLine();
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Sorry! Wrong parameters!");
                                        Console.WriteLine();
                                    }

                                }
                                else if (action == "ChangeId")
                                {
                                    Console.Write("Write company id: ");
                                    string id = Console.ReadLine();
                                    Console.Write("Write new company id: ");
                                    string new_id = Console.ReadLine();
                                    try
                                    {
                                        int i_id = Convert.ToInt32(id);
                                        int inew_id = Convert.ToInt32(new_id);
                                        CompanyManager.Change(i_id, inew_id);
                                        Console.WriteLine();
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Sorry! Wrong parameters!");
                                        Console.WriteLine();
                                    }
                                }
                                else if (action == "ChangeName")
                                {
                                    Console.Write("Write company id: ");
                                    string id = Console.ReadLine();
                                    Console.Write("Write new company name: ");
                                    string new_name = Console.ReadLine();
                                    try
                                    {
                                        int i_id = Convert.ToInt32(id);
                                        CompanyManager.Change(i_id, new_name);
                                        Console.WriteLine();
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Sorry! Wrong parameters!");
                                        Console.WriteLine();
                                    }
                                }
                                else if (action == "Delete")
                                {
                                    Console.Write("Write company id: ");
                                    string id = Console.ReadLine();
                                    try
                                    {
                                        int i_id = Convert.ToInt32(id);
                                        CompanyManager.Delete(i_id);
                                        Console.WriteLine();
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Sorry! Wrong parameters!");
                                        Console.WriteLine();
                                    }
                                }
                                else if (action == "GetAll")
                                {
                                    CompanyManager.GetAll();
                                    Console.WriteLine();
                                }
                                else if (action == "GetById")
                                {
                                    Console.Write("Write company id: ");
                                    string id = Console.ReadLine();
                                    try
                                    {
                                        int i_id = Convert.ToInt32(id);
                                        CompanyManager.GetById(i_id);
                                        Console.WriteLine();
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Sorry! Wrong parameters!");
                                        Console.WriteLine();
                                    }
                                }
                                else if (action == "exit")
                                {
                                    Console.WriteLine();
                                }
                                else
                                {
                                    Console.WriteLine("No matched action!");
                                }
                            }
                        }
                        else if (chosen == "PilotManager")
                        {
                            string action = "n";
                            while (action != "exit")
                            {
                                Console.Write("Choose your action: Add, ChangeId, ChangeExp, Delete, GetAll, GetById or exit: ");
                                action = Console.ReadLine();
                                if (action == "Add")
                                {
                                    Console.Write("Write pilot id: ");
                                    string id = Console.ReadLine();
                                    Console.Write("Write pilot's company id: ");
                                    string c_id = Console.ReadLine();
                                    Console.Write("Write pilot name: ");
                                    string name = Console.ReadLine();
                                    Console.Write("Write pilot's experience: ");
                                    string exp = Console.ReadLine();
                                    try
                                    {
                                        int i_id = Convert.ToInt32(id);
                                        int i_cid = Convert.ToInt32(c_id);
                                        int i_exp = Convert.ToInt32(exp);
                                        PilotManager.Add(i_id, i_cid, name, i_exp);
                                        Console.WriteLine();
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Sorry! Wrong parameters!");
                                        Console.WriteLine();
                                    }

                                }
                                else if (action == "ChangeId")
                                {
                                    Console.Write("Write pilot id: ");
                                    string id = Console.ReadLine();
                                    Console.Write("Write new pilot id: ");
                                    string new_id = Console.ReadLine();
                                    try
                                    {
                                        int i_id = Convert.ToInt32(id);
                                        int inew_id = Convert.ToInt32(new_id);
                                        PilotManager.ChangeId(i_id, inew_id);
                                        Console.WriteLine();
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Sorry! Wrong parameters!");
                                        Console.WriteLine();
                                    }
                                }
                                else if (action == "ChangeExp")
                                {
                                    Console.Write("Write pilot id: ");
                                    string id = Console.ReadLine();
                                    Console.Write("Write new pilot experience: ");
                                    string new_exp = Console.ReadLine();
                                    try
                                    {
                                        int i_id = Convert.ToInt32(id);
                                        int inew_exp = Convert.ToInt32(new_exp);
                                        PilotManager.ChangeExp(i_id, inew_exp);
                                        Console.WriteLine();
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Sorry! Wrong parameters!");
                                        Console.WriteLine();
                                    }
                                }
                                else if (action == "Delete")
                                {
                                    Console.Write("Write pilot id: ");
                                    string id = Console.ReadLine();
                                    try
                                    {
                                        int i_id = Convert.ToInt32(id);
                                        PilotManager.Delete(i_id);
                                        Console.WriteLine();
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Sorry! Wrong parameters!");
                                        Console.WriteLine();
                                    }
                                }
                                else if (action == "GetAll")
                                {
                                    PilotManager.GetAll();
                                    Console.WriteLine();
                                }
                                else if (action == "GetById")
                                {
                                    Console.Write("Write pilot id: ");
                                    string id = Console.ReadLine();
                                    try
                                    {
                                        int i_id = Convert.ToInt32(id);
                                        PilotManager.GetById(i_id);
                                        Console.WriteLine();
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Sorry! Wrong parameters!");
                                        Console.WriteLine();
                                    }
                                }
                                else if (action == "exit")
                                {
                                    Console.WriteLine();
                                }
                                else
                                {
                                    Console.WriteLine("No matched action!");
                                }
                            }
                        }
                        else if (chosen == "TicketManager")
                        {
                            string action = "n";
                            while (action != "exit")
                            {
                                Console.Write("Choose your action: Add, ChangeId, ChangePrice, Delete, GetAll, GetById or exit: ");
                                action = Console.ReadLine();
                                if (action == "Add")
                                {
                                    Console.Write("Write ticket id: ");
                                    string id = Console.ReadLine();
                                    Console.Write("Write departure city id: ");
                                    string c_out = Console.ReadLine();
                                    Console.Write("Write arrival city id: ");
                                    string c_in = Console.ReadLine();
                                    Console.Write("Write departure year: ");
                                    string y = Console.ReadLine();
                                    Console.Write("Write departure month: ");
                                    string mon = Console.ReadLine();
                                    Console.Write("Write departure day: ");
                                    string d = Console.ReadLine();
                                    Console.Write("Write departure hour: ");
                                    string h = Console.ReadLine();
                                    Console.Write("Write departure minute: ");
                                    string min = Console.ReadLine();
                                    Console.Write("Write ticket price: ");
                                    string price = Console.ReadLine();
                                    Console.Write("Write company id: ");
                                    string company = Console.ReadLine();
                                    Console.Write("Write pilot id: ");
                                    string pilot = Console.ReadLine();
                                    try
                                    {
                                        int i_id = Convert.ToInt32(id);
                                        int i_out = Convert.ToInt32(c_out);
                                        int i_in = Convert.ToInt32(c_in);
                                        int i_y = Convert.ToInt32(y);
                                        int i_mon = Convert.ToInt32(mon);
                                        int i_d = Convert.ToInt32(d);
                                        int i_h = Convert.ToInt32(h);
                                        int i_min = Convert.ToInt32(min);
                                        int i_price = Convert.ToInt32(price);
                                        int i_c = Convert.ToInt32(company);
                                        int i_p = Convert.ToInt32(pilot);
                                        TicketManager.Add(i_id, i_out, i_in, i_y, i_mon, i_d, i_h, i_min, i_price, i_c, i_p);
                                        Console.WriteLine();
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Sorry! Wrong parameters!");
                                        Console.WriteLine();
                                    }

                                }
                                else if (action == "ChangeId")
                                {
                                    Console.Write("Write ticket id: ");
                                    string id = Console.ReadLine();
                                    Console.Write("Write new ticket id: ");
                                    string new_id = Console.ReadLine();
                                    try
                                    {
                                        int i_id = Convert.ToInt32(id);
                                        int inew_id = Convert.ToInt32(new_id);
                                        TicketManager.ChangeId(i_id, inew_id);
                                        Console.WriteLine();
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Sorry! Wrong parameters!");
                                        Console.WriteLine();
                                    }
                                }
                                else if (action == "ChangePrice")
                                {
                                    Console.Write("Write ticket id: ");
                                    string id = Console.ReadLine();
                                    Console.Write("Write new ticket price: ");
                                    string new_price = Console.ReadLine();
                                    try
                                    {
                                        int i_id = Convert.ToInt32(id);
                                        int inew_price = Convert.ToInt32(new_price);
                                        TicketManager.ChangePrice(i_id, inew_price);
                                        Console.WriteLine();
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Sorry! Wrong parameters!");
                                        Console.WriteLine();
                                    }
                                }
                                else if (action == "Delete")
                                {
                                    Console.Write("Write ticket id: ");
                                    string id = Console.ReadLine();
                                    try
                                    {
                                        int i_id = Convert.ToInt32(id);
                                        TicketManager.Delete(i_id);
                                        Console.WriteLine();
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Sorry! Wrong parameters!");
                                        Console.WriteLine();
                                    }
                                }
                                else if (action == "GetAll")
                                {
                                    TicketManager.GetAll();
                                    Console.WriteLine();
                                }
                                else if (action == "GetById")
                                {
                                    Console.Write("Write ticket id: ");
                                    string id = Console.ReadLine();
                                    try
                                    {
                                        int i_id = Convert.ToInt32(id);
                                        TicketManager.GetById(i_id);
                                        Console.WriteLine();
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Sorry! Wrong parameters!");
                                        Console.WriteLine();
                                    }
                                }
                                else if (action == "exit")
                                {
                                    Console.WriteLine();
                                }
                                else
                                {
                                    Console.WriteLine("No matched action!");
                                }
                            }
                        }
                        else if (chosen == "exit")
                        {
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("No matched Manager mode");
                        }
                    }
                   

                }
                else if (mode == "Searcher")
                {
                    Console.Write("Write departure city: ");
                    string from = Console.ReadLine();
                    Console.Write("Write arrival city: ");
                    string to = Console.ReadLine();
                    Console.Write("Write departure year: ");
                    string y = Console.ReadLine();
                    Console.Write("Write departure month: ");
                    string mon = Console.ReadLine();
                    Console.Write("Write departure day: ");
                    string d = Console.ReadLine();
                    try
                    {
                        int i_y = Convert.ToInt32(y);
                        int i_m = Convert.ToInt32(mon);
                        int i_d = Convert.ToInt32(d);

                        TicketFinder.Select(from, to, i_y, i_m, i_d);
                    }
                    catch
                    {
                        Console.WriteLine("Sorry! Wrong parameters!");
                        Console.WriteLine();
                    }
                }
                else if (mode == "Buyer")
                {
                    Console.Write("Write ticket to buy id: ");
                    string id = Console.ReadLine();
                    try
                    {
                        int i_id = Convert.ToInt32(id);
                        TicketSeller.Buy(i_id);
                    }
                    catch
                    {
                        Console.WriteLine("Sorry! Wrong parameters!");
                        Console.WriteLine();
                    }

                }
                else if (mode == "Bank")
                {
                    Bank.GetCredit();
                }
                else if (mode == "exit")
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("No matched mode");
                }
            }
           

            CityManager.Add(0, "Paris");
            CityManager.GetAll();
            Console.WriteLine();
            CityManager.Change(0, 1);
            CityManager.Add(2, "Moscow");
            CityManager.Add(3, "Tokyo");
            CityManager.Add(4, "Berlin");
            CityManager.GetAll();
            Console.WriteLine();
            CityManager.Change(10, 15);
            Console.WriteLine();
            CityManager.Delete(4);
            CityManager.Delete(15);
            Console.WriteLine();
            CityManager.GetAll();
            CityManager.Add(4, "Berlin");
            Console.WriteLine();
            CityManager.GetById(1);
            CityManager.GetById(10);
            Console.WriteLine();
            CityManager.Add(4, "Vena");
            CityManager.Add(6, "Berlin");

            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine();

            CompanyManager.Add(0, "Aeroflo");
            CompanyManager.GetAll();
            Console.WriteLine();
            CompanyManager.Change(0, 1);
            CompanyManager.Change(1, "Aeroflot");
            CompanyManager.Add(2, "Air France");
            CompanyManager.Add(3, "Korean Air");
            CompanyManager.Add(4, "Air Japan");
            CompanyManager.Add(4, "Air Japan");
            Console.WriteLine();
            CompanyManager.Change(10, 3);
            Console.WriteLine();
            CompanyManager.GetAll();
            Console.WriteLine();
            CompanyManager.Delete(4);
            CompanyManager.GetAll();
            Console.WriteLine();
            CompanyManager.Delete(8);
            CompanyManager.Add(4, "Air Japan");
            Console.WriteLine();
            CompanyManager.GetById(1);
            CompanyManager.GetById(10);

            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine();

            PilotManager.Add(0, 2, "Egor Drozd", 3);
            PilotManager.GetAll();
            Console.WriteLine();
            PilotManager.ChangeId(0, 1);
            PilotManager.ChangeId(15, 16);
            Console.WriteLine();
            Console.WriteLine();
            PilotManager.ChangeExp(1, 6);
            PilotManager.Add(2, 2, "Lui Mua", 10);
            PilotManager.Add(3, 3, "Jon Nji", 15);
            PilotManager.Add(4, 4, "Hiro Soki", 15);
            PilotManager.Add(4, 4, "Hiro Soki", 15);
            Console.WriteLine();
            PilotManager.GetAll();
            Console.WriteLine();
            PilotManager.Delete(4);
            PilotManager.Delete(10);
            Console.WriteLine();
            PilotManager.GetAll();
            PilotManager.Add(4, 4, "Hiro Soki", 15);
            Console.WriteLine();
            PilotManager.GetById(1);
            PilotManager.GetById(10);

            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine();

            TicketManager.Add(0, 1, 2, 2019, 10, 05, 18, 30, 150, 2, 2);
            TicketManager.GetAll();
            Console.WriteLine();
            TicketManager.ChangeId(0, 1);
            TicketManager.ChangeId(11, 1);
            Console.WriteLine();
            TicketManager.ChangePrice(1, 100);
            TicketManager.ChangePrice(11, 100);
            Console.WriteLine();
            TicketManager.Add(2, 4, 1, 2019, 10, 06, 11, 00, 200, 1, 1);
            TicketManager.Add(2, 4, 1, 2019, 10, 06, 11, 00, 200, 1, 1);
            Console.WriteLine();
            TicketManager.Add(3, 3, 4, 2019, 10, 07, 12, 25, 300, 3, 3);
            TicketManager.Add(4, 2, 3, 2019, 10, 08, 13, 45, 400, 4, 4);
            TicketManager.Add(5, 1, 2, 2019, 10, 05, 17, 45, 400, 4, 4);
            TicketManager.Add(6, 1, 2, 2019, 10, 05, 19, 45, 230, 3, 3);
            TicketManager.Add(7, 1, 2, 2019, 10, 05, 14, 45, 340, 1, 1);
            TicketManager.Add(8, 1, 2, 2019, 11, 05, 14, 45, 340, 1, 1);
            TicketManager.GetAll();
            Console.WriteLine();
            TicketManager.Delete(8);
            TicketManager.Delete(15);
            Console.WriteLine();
            TicketManager.GetAll();
            TicketManager.Add(8, 1, 2, 2019, 11, 05, 14, 45, 340, 1, 1);
            Console.WriteLine();
            TicketManager.GetById(1);
            TicketManager.GetById(11);

            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine();

            TicketFinder.Select("Paris", "Moscow", 2019, 10, 05);
            Console.WriteLine();
            TicketFinder.Select("Moscow", "Paris", 2019, 10, 05);
            Console.WriteLine();
            TicketFinder.Select("London", "Paris", 2019, 10, 05);

            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine();

            TicketSeller.Buy(1);
            Console.WriteLine();
            TicketSeller.Buy(15);
            Console.WriteLine();
            TicketManager.GetAll();

            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine();

            Bank.GetCredit();
            Console.WriteLine();
            Bank.GetCredit();
            Console.WriteLine();
            Bank.GetCredit();
            Console.WriteLine();
            Bank.GetCredit();
            Console.WriteLine();
            Bank.GetCredit();


        }
    }
}
