namespace DoctorsWaitingRoom;

public class WaitingRoom
{
    private int currentNumber = 0;
    private int ticketCount = 0;
    
    //Action to notify patients when the ticket number is changed
    public event Action<int> NumberChange;
    
    //Method to run the waiting room simulation
    public void RunWaitingRoom()
    {
        while (currentNumber < ticketCount)
        {
            Console.WriteLine("Diing!");
            NumberChange?.Invoke(currentNumber);
            currentNumber++;
            Thread.Sleep(1000);
        }
    }

    public int DrawNumber()
    {
        ticketCount++;
        return ticketCount;
    }
}