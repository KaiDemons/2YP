using System;

class Train
{
   public string ТameOfDestination { get; set; }
   public int TrainNumber { get; set; }
   public string DepartureTime { get; set; }

   public void PrintTrainInfo()
   {
      Console.WriteLine($"Train Number: {TrainNumber}");
      Console.WriteLine($"Destination: {ТameOfDestination}");
      Console.WriteLine($"Departure Time: {DepartureTime}");
   }

   static void Main()
   {
      Train[] trains = new Train[5];
      trains[0] = new Train { TrainNumber = 432, ТameOfDestination = "Tomsk", DepartureTime = "07:45" };
      trains[1] = new Train { TrainNumber = 642, ТameOfDestination = "Moscow", DepartureTime = "15:32" };
      trains[2] = new Train { TrainNumber = 842, ТameOfDestination = "Omsk", DepartureTime = "20:15" };
      trains[3] = new Train { TrainNumber = 126, ТameOfDestination = "Vladivostok", DepartureTime = "18:50" };
      trains[4] = new Train { TrainNumber = 782, ТameOfDestination = "Kazan", DepartureTime = "13:22" };
      
      Console.WriteLine("Enter the train number to get information:");
      int inputTrainNumber = int.Parse(Console.ReadLine());
      
      bool trainFound = false;
      foreach (Train train in trains)
      {
         if (train.TrainNumber == inputTrainNumber)
         {
            train.PrintTrainInfo();
            trainFound = true;
            break;
         }
      }

      if (!trainFound)
      {
         Console.WriteLine("Train not found with the entered number.");
      }
   }
}   