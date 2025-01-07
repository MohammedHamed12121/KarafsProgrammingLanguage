if (args.Length > 1)
{
	Console.WriteLine("Usage: Karafs [script]");
	Environment.Exit(64);
}
else if (args.Length == 1)
{
	RunFile(args[0]);
}
else
{
	RunPrompt();
}

void RunFile(string path)
{
    try
    {
        string content = File.ReadAllText(path);
        Run(content);
    }
    catch (IOException ex)
    {
        Console.WriteLine($"Error reading file: {ex.Message}");
        Environment.Exit(74); // IO error code
    }
}

void RunPrompt()
{
    while (true)
    {
        Console.Write("> ");
        string line = Console.ReadLine() ?? "";

        if(line == "exit()")
	        Environment.Exit(64);
            
        Run(line);
    }
}

void Run(string content)
{   
    Console.WriteLine(content);
}