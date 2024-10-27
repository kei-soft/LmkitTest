namespace ConsoleApp.lmkitTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // See https://aka.ms/new-console-template for more information
            var model = new LMKit.Model.LLM(@"G:\Huggingface-model\EEVE-Korean-Instruct-10.8B-v1.0\EEVE-Korean-Instruct-10.8B-v1.0-Q8_0.gguf");

            var chat = new LMKit.TextGeneration.MultiTurnConversation(model);

            var response = chat.Submit("대한민국의 수도는?");

            Console.WriteLine("Response: " + response.Completion);
        }
    }
}
