using System;
using System.IO;
using Antlr4.Runtime;

using AntlrExamples.Parser;
using AntlrExamples.Environment;

[assembly: CLSCompliant(false)]

namespace AntlrExamples
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string path = "/home/mahmoud/test.arac";
            string input = File.ReadAllText(path);

            ICharStream charStream = CharStreams.fromString(input);
            ITokenSource tokenSource = new aracLexer(charStream);
            ITokenStream tokenStream = new CommonTokenStream(tokenSource);
            aracParser araCParser = new aracParser(tokenStream);

            var program = araCParser.program();

            SymTab symbol_table = ParseTreeWalker.GenerateTable(program, null);
            SymTab.print_symbol_table(symbol_table);
            // var ast_root = ASTGenerator.GenerateAST(program);

            // SymTab sym_tab = ASTWalker.construct_table(ast_root, null);
            
            
            // Console.WriteLine(ast_root.GetType().Name);
            
            // String graph = ASTDotGraphGenerator.getGarph(ast_root);
            // FileStream output_graph_file = File.Open("/home/mahmoud/output.dot", FileMode.Create);
            
            // output_graph_file.Write(Encoding.UTF8.GetBytes(graph.ToCharArray()));
            // output_graph_file.Close();
            // Console.WriteLine(graph);
             
        }
        

    }
}
