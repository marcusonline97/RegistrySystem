using RegistrySystem.ProjectFolder;
using System.Xml.Schema;

namespace RS
{
    public class RegistrySystem
    {
        public bool IsRunning = true;
        public SelectionScreen screen = SelectionScreen.MainMenu;
        public void PrintCurrentMenu()
        {
            Console.Clear();
            switch (screen)

            {
                case SelectionScreen.MainMenu:
                    Console.WriteLine("1) Press To Book a ticket");
                    Console.WriteLine("2) Press To Clear a booked ticket");
                    Console.WriteLine("3) Press 3 To Review Prices");
                    Console.WriteLine("4) Press 4 to End the ticket program");
                    break;
                case SelectionScreen.BookTicket:
                    Console.WriteLine($"Apply your age"); 

                    break;
                case SelectionScreen.ClearTicket:
                    Console.WriteLine(""); //Here we will see the added tickets in case if we want to delete one 
                    break;
                case SelectionScreen.ReviewTicket: //Fetch the added ticket from the list currently added
                                                   //tickets and their individual costs & total sum.
                                                   //If no tickets are applied then return to SelectionScreen.MainMenu 

                    Console.WriteLine("");
                    break;
                case SelectionScreen.EndApplication:
                    IsRunning = false;
                    break;
            }
        }
  
        public void HandleInput()
        {
            switch (screen)
            {
                case SelectionScreen.MainMenu:
                    Console.WriteLine("Select Option: ");
                    string optionText = Console.ReadLine();
                    int selectedOption = int.Parse(optionText);
                    switch (selectedOption)
                    {
                        case 1:screen = SelectionScreen.BookTicket;
                            break;
                        case 2: screen = SelectionScreen.ClearTicket;
                            break;
                        case 3:screen = SelectionScreen.ReviewTicket;
                            break;
                        case 4:screen = SelectionScreen.EndApplication;
                            break;
                            default: Console.WriteLine("big banana");
                            break;

                    }
                    break;
                case SelectionScreen.BookTicket:
                    Console.WriteLine("How many of you are visiting: \n ");
                    string visitors = Console.ReadLine();
                    int amountofVisitors = int.Parse(visitors);
                    List<int>ageList = new List<int>();
                    for (int i = 0; i < amountofVisitors; i++)
                    {
                        Console.WriteLine("|Visitor " + i+1 + "| age: |");
                        string age = Console.ReadLine();
                        int a = int.Parse(visitors);
                        ageList.Add (a);
                        
                    }
                    break;
                case SelectionScreen.ClearTicket:
                    Utility.ClearTicket();
                    break;
                case SelectionScreen.ReviewTicket:
                    break;
                case SelectionScreen.EndApplication:
                    break;
                default:
                    break;
            }
        }

        public int CalculateTotal(int amountOfVisitor, List<int>userAge,int total = 0)
        {
            for (int i = 0; i < amountOfVisitor; i++)
            {
                total += CalculateDiscount(userAge[i]);

            }
            return total;

        }


        /// <summary>
        ///  User puts in an integer. The integer gets determined by an if or switch statement if below 20 then young discount,
        /// if above 65 then old discount. Any other valid int will result in default price. Anything that is not supported like a string or a double will result in an
        /// error message and send them back to the same page.
        /// </summary>
        /// <returns></returns>
        public int CalculateDiscount(int age)
        {


            if (age < 20) // The Teen Tier Price
            {
                return (80); //Return int 80
            }
            else if (age < 66) //default Price
            {
                return (120); //return int 120
            }

            else //The Elderly Tier Price
            {
                return (90);//Default price
            }

        }


   
   
    }

}
