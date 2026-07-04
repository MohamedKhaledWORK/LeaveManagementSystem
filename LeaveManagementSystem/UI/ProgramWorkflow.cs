using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagementSystem.UI
{
    public static class ProgramWorkflow
    {
        public static void SystemFlow()
        {
            while (true)
            {
                ProgramMenu.DisplayMenu();

                bool flag;
                int choice;
                do
                {
                    Console.Write("Please select an option: ");
                    flag = int.TryParse(Console.ReadLine(), out choice);

                } while (!flag || choice < 1 || choice > 4);
                if (choice == 4)
                {
                    Console.WriteLine("Exiting the system. Goodbye!");
                    break;
                }
                switch (choice)
                {
                    case 1:
                        while (true)
                        {
                            ProgramMenu.AdminMenu();
                            do
                            {
                                Console.Write("Please select an option: ");
                                flag = int.TryParse(Console.ReadLine(), out choice);

                            } while (!flag || choice < 1 || choice > 9);
                            if (choice == 9)
                            {
                                Console.WriteLine("Back to Main Menu");
                                break;
                            }
                            AdminFlow.AdminFlowMethod(choice);
                        }
                        break;
                    case 2:
                        while (true)
                        {
                            ProgramMenu.ManagerMenu();
                            do
                            {
                                Console.Write("Please select an option: ");
                                flag = int.TryParse(Console.ReadLine(), out choice);

                            } while (!flag || choice < 1 || choice > 3);
                            if (choice == 3)
                            {
                                Console.WriteLine("Back to Main Menu");
                                break;
                            }
                            ManagerFlow.ManagerFlowMethod(choice);
                        }
                        break;

                    case 3:
                        while (true)
                        {
                            ProgramMenu.EmployeeMenu();
                            do
                            {
                                Console.Write("Please select an option: ");
                                flag = int.TryParse(Console.ReadLine(), out choice);

                            } while (!flag || choice < 1 || choice > 2);
                            if (choice == 2)
                            {
                                Console.WriteLine("Back to Main Menu");
                                break;
                            }
                            EmployeeFlow.EmployeeFlowMethod(choice);
                        }
                        break;
                }
            }
        }
    }
}
