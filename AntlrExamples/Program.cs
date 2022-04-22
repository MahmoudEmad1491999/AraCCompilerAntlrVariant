using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using AntlrExamples.AST;
using AntlrExamples.Parser;
using AntlrExamples.Environment;

using System.Collections.Generic;

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
            

            SymbolTableGenerator symbolTableGenerator = new SymbolTableGenerator();
            var table = symbolTableGenerator.GenerateSymTab(program, null);

            // var ast_root = ASTGenerator.GenerateAST(program);

            // SymTab sym_tab = ASTWalker.construct_table(ast_root, null);
            

            print_table(table);
            

            // Console.WriteLine(ast_root.GetType().Name);
            
            // String graph = ASTDotGraphGenerator.getGarph(ast_root);
            // FileStream output_graph_file = File.Open("/home/mahmoud/output.dot", FileMode.Create);
            
            // output_graph_file.Write(Encoding.UTF8.GetBytes(graph.ToCharArray()));
            // output_graph_file.Close();
            // Console.WriteLine(graph);
             
        }
        public static void print_table(SymTab table) {
            foreach(var entry in table.entries)
            {
                Console.WriteLine("SymbolTable: " + table.GetType() + ", Symbol Identifier: " + entry.sym_id + ", Symbol Type: " + entry.sym_type);
            }
            foreach(var sub_table in table.sub_tables)
            {
                print_table(sub_table);
            }
        }

    }
}
