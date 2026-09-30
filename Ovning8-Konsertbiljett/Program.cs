CreateAndPrintTicket();

static void CreateAndPrintTicket()
{
    Ticket ticket = new Ticket();

    ticket.ReadInfo();
    ticket.PrintTicket();
}
