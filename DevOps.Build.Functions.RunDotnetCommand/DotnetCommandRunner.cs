using static Common.Functions.RunCommandLineTool.CommandLineToolRunner;

namespace DevOps.Build.Functions.RunDotnetCommand
{
    public static class DotnetCommandRunner
    {
        private const string dotnet = nameof(dotnet);

        public static void Dotnet(string directory, string command, params string[] arguments)
            => Prompt(directory,
                tool: dotnet,
                command,
                arguments);
    }
}
