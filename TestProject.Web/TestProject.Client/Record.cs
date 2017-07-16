using System;

namespace TestProject.Client
{
    public class Record
    {
        private string userName;
        private string userRecord;

        public Record()
        {
            userName = "";
            userRecord = "";
        }

        public void Create()
        {
            while (userName.Length < 4 || userName.Length > 20)
            {
                Console.Clear();
                Console.Write("Type in your name (it must be more than 4 and less than 20 symbols): ");
                userName = Console.ReadLine();
            }

            while (userRecord.Length < 1 || userRecord.Length > 100)
            {
                Console.Clear();
                Console.Write($"Your name: {userName}\nType in your message (it must be more than 1 and less than 100 symbols): ");
                userRecord = Console.ReadLine();
            }

            Console.Clear();
            Console.WriteLine($"Your name: {userName}\nYour message: {userRecord}");
        }

        public void Post()
        {
            var model = new
            {
                userName,
                userRecord
            };

            Console.WriteLine("Please, wait while your message is uploading...");

            Console.WriteLine(Request<object>.PostRequest(model, "api/RecordApi/PostRecord/")
                ? "Your message was uploaded successfully."
                : "There was a problem during your message uploading.");
        }
    }
}
