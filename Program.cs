public class Program
{
	static string path = @"your_directory";
	static string file_name = "log.txt";

	static void Main()
	{
		GetInput();
	}

	static void WriteLog(string? msg)
	{
		// If file doesn't exist then creates one and appending text into end of content
		File.AppendAllText(Path.Combine(path, file_name), msg);
	}

	static void GetInput()
	{
		Console.WriteLine("Write your message to save, write `q` to exit");

		string? input = Console.ReadLine();

		if (input is "q") return;

		// \n is breakpoint in text where next text will start in new paragraphy
		string msg = input + " : " + DateTime.Now + "\n";

		WriteLog(msg);

		Console.WriteLine("Your message saved");

		// The method that exits in Helper class to add seperate line in console
		SeperateLine(60);

		GetInput();
	}

}