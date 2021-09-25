using System;
using MLDigitAppML.Model;

namespace MLDigitApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Predicting numbers!");
            Console.WriteLine("This app tries to recognize handwritten numbers.\n\n");

            string path;

            while (true)
            {
                Console.WriteLine("Please enter the full path to an image of a number (e.g C:\\Documents\\Images\\1.png) or type 'exit' to quit.\n");

                path = Console.ReadLine();

                if (path == "exit") {
                    return;
                }

                Console.WriteLine("\n");

                try {
                    ModelInput input = new ModelInput() {
                        ImageSource = @path,
                    };

                    ModelOutput result = ConsumeModel.Predict(input);

                    Console.WriteLine("Using model to make single prediction -- Comparing actual Label with predicted Label from sample data...\n\n");
                    Console.WriteLine($"ImageSource: {input.ImageSource}");
                    Console.WriteLine($"\n\nPredicted Label value {result.Prediction} \nPredicted Label scores: [{String.Join(",", result.Score)}]\n\n");
                } catch(Exception e) {
                    Console.Error.WriteLine("\n");
                    Console.Error.WriteLine(e.Message);
                    Console.Error.WriteLine("\nWe were not able to process the image. Please make sure you have provided the correct path and try again.\n\n");
                }
     
            }
        }
    }
}
