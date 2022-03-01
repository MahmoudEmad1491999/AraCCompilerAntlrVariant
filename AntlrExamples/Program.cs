using System;
using Antlr4.Runtime;
using AntlrOutput;
namespace AntlrExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "Hello mahmoud";
            ICharStream charStream = CharStreams.fromString(input);
            ITokenSource tokenSource = new AraCLexer(charStream);
            ITokenStream tokenStream = new CommonTokenStream(tokenSource);
            AraCParser speakerParser = new AraCParser(tokenStream);
            
            Console.WriteLine("Hello World!");
        }
    }
}
