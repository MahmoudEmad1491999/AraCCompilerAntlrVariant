using System;
using Antlr4.Runtime;
using AntlrOutput;
namespace AntlrExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "hello mahmoud";
            ICharStream charStream = CharStreams.fromString(input);
            ITokenSource tokenSource = new SpeakerLexer(charStream);
            ITokenStream tokenStream = new CommonTokenStream(tokenSource);
            SpeakerParser speakerParser = new SpeakerParser(tokenStream);
            
            Console.WriteLine("Hello World!");
        }
    }
}
