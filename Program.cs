using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using File_I_O;

namespace BaseballTweaker_V1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
          //  List<string> names = new List<string>();
            var batting_stats = Input.RetrieveAllBattingRecords();
            var pitching_stats = Input.RetrieveAllPitchingRecords();

            OutputToConsole.OutputToConsoleAndFileBattingRecords(batting_stats);
            OutputToConsole.OutputToConsoleAndFilePitchingRecords(pitching_stats);
            

         

           //onsole.ReadLine();
        }



        
    }
}
