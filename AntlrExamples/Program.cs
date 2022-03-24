using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using Parser;
using static Parser.AraCParser;

using System.Collections.Generic;

[assembly: CLSCompliant(false)]

namespace AntlrExamples
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string path = "/home/mahmoud/testfile.arac";
            string input = File.ReadAllText(path);

            ICharStream charStream = CharStreams.fromString(input);
            ITokenSource tokenSource = new AraCLexer(charStream);
            ITokenStream tokenStream = new CommonTokenStream(tokenSource);
            AraCParser araCParser = new AraCParser(tokenStream);
            
            var item = araCParser.program();
            var dotgraph = DotGraphGenerator.getGarph(item);

            String graph = "digraph graph_name { " + dotgraph + "}";
            Console.WriteLine(graph);
        }
       
    }
}
