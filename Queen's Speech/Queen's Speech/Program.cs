using System;
using System.IO;

namespace Queen_s_Speech
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Government = new string[3];
            Government[0] = "Labour";
            Government[1] = "Conservative";
            Government[2] = "Coalition";

            string[] files = new string[5];
            files[0] = (@"C:\Users\user\Documents\AI\Coalition9thMay2012");
            files[1] = (@"C:\Users\user\Documents\AI\Conservative16thNov1994");
            files[2] = (@"C:\Users\user\Documents\AI\Conservative27thMay2015");
            files[3] = (@"C:\Users\user\Documents\AI\Labour6thNov2007");
            files[4] = (@"C:\Users\user\Documents\AI\Labour26thNov2003");

            foreach (string gov in Government) 

            {
                double i = 0D;
                foreach (string file in files)
                {
                    if (file == gov) i++;
                {
                        if (gov == "Labour")
                        {
                            double labPrior = i / 5;
                        }
                        Console.WriteLine("labPrior");
                        {

                            if (gov == "Conservative")
                            {
                                double conPrior = i / 5;
                            }

                            Console.WriteLine("conPrior");
                        }
                        {
                            if (gov == "Coalition")
                            {
                                double coaPrior = i / 5;
                            }

                            Console.WriteLine("coaPrior");
                        }
                 
                 foreach ( string gov in Government) //??????
                        { 
                            foreach (string file in files) ///// ?????
                            {
                                if (file == gov)
                                {
                                    string file = "[0], [1], [2], [3], [4]";
                                    string inputString = File.Readalltext(file); //read lowercase then count word frequency 

                                    inputString = inputString.ToLower();

                                    StreamReader sr = new StreamReader(file);

                                }



                            }

                        }

                        

                           


                            

}
                }
                    }
                        
                }
            }
   
                

           




        }
        
   
    