using System;
using System.IO;
using System.Linq;
// using System.Collections.Generic;
using Antlr4.Runtime;
using AntlrOutput;


[assembly: CLSCompliant(false)]

namespace AntlrExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MahmoudEmad");
            string path = "/home/mahmoud/AraCAntlrVariant/AntlrExamples/testfile.arac";
            string input = File.ReadAllText(path);

            ICharStream charStream = CharStreams.fromString(input);
            ITokenSource tokenSource = new AraCLexer(charStream);
            ITokenStream tokenStream = new CommonTokenStream(tokenSource);
            AraCParser araCParser = new AraCParser(tokenStream);
            AraCParser.ProgramContext programContext = araCParser.program();




        }
    }
}
