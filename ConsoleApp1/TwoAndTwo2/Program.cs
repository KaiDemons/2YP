using System;

class Train
{
   public string ТameOfDestination { get; set; }
   public int TrainNumber { get; set; }
   public DateTime DepartureTime { get; set; }

   public void PrintTrainInfo()
   {
      Console.WriteLine($"Train Number: {TrainNumber}");
      Console.WriteLine($"Destination: {ТameOfDestination}");
      Console.WriteLine($"Departure Time: {DepartureTime}");
   }

   static void Main()
   {
      Train[] trains = new Train[5];
      trains[0] = new Train { TrainNumber = 432, ТameOfDestination = "Tomsk", DepartureTime = new DateTime(2024,04,20,17,15,00) };
      trains[1] = new Train { TrainNumber = 642, ТameOfDestination = "Moscow", DepartureTime =  new DateTime(2024,08,24,8,15,00) };
      trains[2] = new Train { TrainNumber = 842, ТameOfDestination = "Omsk", DepartureTime = new DateTime(2024,12,24,20,10,00) };
      trains[3] = new Train { TrainNumber = 126, ТameOfDestination = "Vladivostok", DepartureTime = new DateTime(2024,07,5,12,05,00) };
      trains[4] = new Train { TrainNumber = 782, ТameOfDestination = "Kazan", DepartureTime = new DateTime(2025,1,12,20,18,00) };
      
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