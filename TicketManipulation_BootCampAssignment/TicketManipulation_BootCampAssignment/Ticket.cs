using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketManipulation_BootCampAssignment.Ticket
{
    class Ticket
    {
        public Status State;

        public Ticket()
        {
            string ticketId = "";
            string title;
            string ticketDescription;
            State = Status.New;
        }

        public void CreateTicket()
        {
            string ticketType;
            Console.WriteLine("**** Enter Ticket type: ****");
            Console.WriteLine("1.Bug");
            Console.WriteLine("2.Feature");
            Console.WriteLine("3.Task");
            Console.WriteLine("Enter the option number:");
            string ticketTypeOption = Console.ReadLine();
            Console.WriteLine("Enter the Title:");
            string title = Console.ReadLine();
            Console.WriteLine("Enter the Description:");
            string ticketDescription = Console.ReadLine();
            switch (Int32.Parse(ticketTypeOption))
            {
                case 1:
                    ticketType = "Bug";
                    break;
                case 2:
                    ticketType = "Feature";
                    break;
                case 3:
                    ticketType = "Task";
                    break;
                default:
                    ticketType = "Other";
                    break;
            }

        }
        public void GetNewTicketDetails()
        {
            switch (State)
            {
                    case 
            }
        }


        public enum Status
        { New, InProgress, Qa, Done }

    }
}
