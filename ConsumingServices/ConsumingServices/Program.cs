using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace ConsumingServices
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string option = "1";


            while (option != "3")
            {
                Console.Clear();
                Console.WriteLine("This program offers different options: ");
                Console.WriteLine("1.- We input a text and the text will be evaluated if it is positive, negative or neutral");
                Console.WriteLine("2.- We input an image and the image we will be analyzed");
                Console.WriteLine("3.- Quit the program");
                Console.WriteLine("Both options uses the Cognitive Services by Microsoft Azure");
                Console.Write("Enter your option: ");
                option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        await analyzeText();
                        break;
                    case "2":
                        await analyzeImage();
                        break;
                    case "3":
                        Console.WriteLine("Thanks for using this program. See you soon :)");
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }

            }
        }

        static async Task analyzeText()
        {
            string textToAnalyze;
            Console.WriteLine("We are going to use TextAnalytics :) ");
            Console.WriteLine("Enter a phrase you would like to analyze: ");
            textToAnalyze = Console.ReadLine();
            Console.WriteLine("Analyzing text...wait a moment.");
            string result = await callToTextAnalyticsAPI(textToAnalyze);
            Console.WriteLine("The result is");
            Console.WriteLine(result);
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }

        static async Task<string> callToTextAnalyticsAPI(string textToAnalyze)
        {
            var client = new HttpClient();
            string url = "https://danielscognservice.cognitiveservices.azure.com/text/analytics/v3.2-preview.1/sentiment?opinionMining=true";
            string cogSvcKey = "46cdc71e83024398a9fc82c9dd901e77";
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", cogSvcKey);
            //client.DefaultRequestHeaders.Add("Content-Type", "application/json");
            client.DefaultRequestHeaders
            .Accept
            .Add(new MediaTypeWithQualityHeaderValue("application/json"));


            string otherData = "{ documents: [{ id: '1', text: '"+ textToAnalyze+"'}]}";
            HttpContent theData = new StringContent(otherData, System.Text.Encoding.UTF8, "application/json");

            var httpResponse = await client.PostAsync(url, theData);
     
            
            if (httpResponse.IsSuccessStatusCode)
            {
                var result = httpResponse.Content.ReadAsStringAsync().Result;
                return result.ToString();
            }
            else
            {
                return "There was an error";
            }
            

        }

        static async Task analyzeImage()
        {

            string imgPath;

            Console.WriteLine("We are going to use ComputerVision :) ");
            Console.WriteLine("Enter the path of the image you would like to analyze: ");
            imgPath = Console.ReadLine();
            Console.WriteLine("Analyzing image...wait a moment.");
            string result = await callToComputerVisionAPI(imgPath);
            Console.WriteLine("The result is");
            Console.WriteLine(result);
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }


        static async Task<string> callToComputerVisionAPI(string imgPath)
        {
            var client = new HttpClient();
            string url = "https://danielscognservice.cognitiveservices.azure.com/vision/v2.1/analyze?visualFeatures=Description,Tags,Categories&details=Celebrities,Landmarks";
            string cogSvcKey = "46cdc71e83024398a9fc82c9dd901e77";
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", cogSvcKey);
            //client.DefaultRequestHeaders.Add("Content-Type", "application/json");
            client.DefaultRequestHeaders
            .Accept
            .Add(new MediaTypeWithQualityHeaderValue("application/json"));


            string otherData = "{ url: '" + imgPath + "'}";
            HttpContent theData = new StringContent(otherData, System.Text.Encoding.UTF8, "application/json");

            var httpResponse = await client.PostAsync(url, theData);


            if (httpResponse.IsSuccessStatusCode)
            {
                var result = httpResponse.Content.ReadAsStringAsync().Result;
                return result.ToString();
            }
            else
            {
                return "There was an error";
            }
        }
    }
}
