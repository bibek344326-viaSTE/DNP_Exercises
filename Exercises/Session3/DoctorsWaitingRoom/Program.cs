using System;
using System.Collections.Generic;
using DoctorsWaitingRoom;

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of the WaitingRoom
        WaitingRoom waitingRoom = new WaitingRoom();

        // Create a few patients and add them to the waiting room
        Patient patient1 = new Patient(waitingRoom);
        Patient patient2 = new Patient(waitingRoom);
        Patient patient3 = new Patient(waitingRoom);

        // Run the waiting room simulation
        waitingRoom.RunWaitingRoom();
    }
}