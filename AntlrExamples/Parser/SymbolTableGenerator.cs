using AntlrExamples.Environment;
using System.Collections.Generic;
using Antlr4.Runtime.Tree;
namespace AntlrExamples.Parser{
    public class SymbolTableGenerator
    {
        public SymTab GenerateSymTab(IParseTree head, SymTab parent){
            List<SymTabEntry> entries = new List<SymTabEntry>();
            List<SymTab> sub_tables = new List<SymTab>();
            SymTab result_table;
            if(head is aracParser.ProgramContext){
                var new_head = (aracParser.ProgramContext) head;
                result_table = new ProgramSymTab(entries, parent, sub_tables);
                for(int index = 0; index < new_head.children.Count; index++)
                {
                    result_table.addEntry(GenerateEntry(new_head.children[index]));
                    result_table.addSubTable(GenerateSymTab(new_head.children[index], result_table));
                }
                return result_table;
            }else if(head is aracParser.FunctionDeclContext){
                var new_head = (aracParser.FunctionDeclContext) head;
                result_table = new FuncSymTab(entries, parent,sub_tables);
                for(int index = 0; index < new_head.children.Count; index++)
                {
                    result_table.addEntry(GenerateEntry(new_head.children[index]));
                    result_table.addSubTable(GenerateSymTab(new_head.children[index], result_table));
                }
                return result_table;
            }else if(head is aracParser.OperationDeclContext){
                var new_head = (aracParser.OperationDeclContext) head;
                result_table = new OperSymTab(entries, parent, sub_tables);
                for(int index = 0; index < new_head.children.Count; index++)
                {
                    result_table.addEntry(GenerateEntry(new_head.children[index]));
                    result_table.addSubTable(GenerateSymTab(new_head.children[index], result_table));
                }
                return result_table;
            }else if(head is aracParser.StatementListContext){
                var new_head = (aracParser.StatementListContext) head;
                var statement_list = new_head.statement();
                
                for(int index = 0; index < statement_list.Length; index++){
                    parent.addEntry(GenerateEntry(statement_list[index]));
                    parent.addSubTable(GenerateSymTab(statement_list[index], parent));
                }
            }else if(head is aracParser.If_StatContext){
                var new_head = (aracParser.If_StatContext) head;
                var statements = new_head.ifStat().statementList().statement();
                result_table = new IfStatSymTab(entries, parent, sub_tables);
                for(int index  = 0; index < statements.Length; index++ )
                {
                    result_table.addEntry(GenerateEntry(statements[index]));
                    result_table.addSubTable(GenerateSymTab(statements[index], result_table));
                }
                return result_table;
            }else if(head is aracParser.While_StatContext){
                var new_head = (aracParser.If_StatContext) head;
                var statements = new_head.ifStat().statementList().statement();
                result_table = new WhileStatSymTab(entries, parent, sub_tables);
                for(int index  = 0; index < statements.Length; index++ )
                {
                    result_table.addEntry(GenerateEntry(statements[index]));
                    result_table.addSubTable(GenerateSymTab(statements[index], result_table));
                }
                return result_table;
            }
            return null;
        } 
        public SymTabEntry GenerateEntry(IParseTree parse_tree_node){
            if(parse_tree_node is aracParser.GlobalVarDeclContext){
                var new_parse_tree_node = (aracParser.GlobalVarDeclContext) parse_tree_node;
                return new GVarSymTabEntry(new_parse_tree_node.ID().GetText(), new_parse_tree_node.dataType().GetText());
            }else if(parse_tree_node is aracParser.FunctionDeclContext){
                var new_parse_tree_node = (aracParser.FunctionDeclContext) parse_tree_node;
                return new FuncSymTabEntry(new_parse_tree_node.ID().GetText(), new_parse_tree_node.dataType().GetText());
            }else if(parse_tree_node is aracParser.OperationDeclContext){
                var new_parse_tree_node = (aracParser.OperationDeclContext) parse_tree_node;
                return new OperSymTabEntry(new_parse_tree_node.ID().GetText());
            }else if(parse_tree_node is aracParser.Var_DeclContext){
                var new_parse_tree_node = (aracParser.Var_DeclContext) parse_tree_node;
                return new LVarSymTabEntry(new_parse_tree_node.varDecl().ID().GetText(), new_parse_tree_node.varDecl().dataType().GetText());
            }
            return null;
        }
    }
}