namespace DoctorsWaitingRoom;

public class Patient
{
    private readonly int _numberInQueue;
    private readonly WaitingRoom _waitingRoom;

    public Patient(WaitingRoom waitingRoom)
    {
        this._waitingRoom = waitingRoom;
        _numberInQueue = waitingRoom.DrawNumber();
        waitingRoom.NumberChange += ReactToNumberChange;
        Console.WriteLine($"Patient {_numberInQueue} has entered the waiting room.");
    }

    private void ReactToNumberChange(int ticketNumber)
    {
        if (ticketNumber == _numberInQueue)
        {
            // Patient's turn
            Console.WriteLine($"Patient {_numberInQueue} looks up");
            Console.WriteLine($"Patient {_numberInQueue} goes to the doctor's room");

            // Unsubscribe from the event when the patient has been called
            _waitingRoom.NumberChange -= ReactToNumberChange;
        }
        else
        {
            // It's not the patient's turn
            Console.WriteLine($"Patient {_numberInQueue} looks up");
            Console.WriteLine($"Patient {_numberInQueue} goes back to looking at phone");

        }
    }
}