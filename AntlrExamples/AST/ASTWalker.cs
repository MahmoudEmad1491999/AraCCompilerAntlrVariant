using System;
using AntlrExamples.Environment;
using System.Collections.Generic;


namespace AntlrExamples.AST
{
    public static class ASTWalker
    {
        public static SymTab construct_table(Node head, SymTab parent)
        {
            SymTab sym_table = null;
            List<SymTab> sub_tables = new List<SymTab>();
            List<SymTabEntry> entries = new List<SymTabEntry>();
            if (head is Program)
            {
                Program root_program = (Program)head;
                sym_table = new FileSymTab(entries, parent, sub_tables);

                foreach (var declaration in root_program.declarations)
                {
                    sym_table.addEntry(walk(declaration));
                }
                foreach (var declaration in root_program.declarations)
                {
                    sym_table.addSubTable(construct_table(declaration, sym_table));
                }
                return sym_table;

            }
            else if (head is OperationDeclaration)
            {
                OperationDeclaration operation_declaration = (OperationDeclaration)head;
                sym_table = new OperSymTab(entries, parent, sub_tables);
                
                foreach (var parameter in ((ParameterList)operation_declaration.parameter_list).parameters)
                {
                    sym_table.addEntry(walk(parameter));
                }
                foreach (var statement in ((StatementList)operation_declaration.statement_list).statements)
                {
                    sym_table.addEntry(walk(statement));
                }
                foreach (var statement in ((StatementList)operation_declaration.statement_list).statements)
                {
                    sym_table.addSubTable(construct_table(statement, sym_table));
                }
                return sym_table;
            }
            else if (head is FunctionDeclaration)
            {
                FunctionDeclaration function_declaration = (FunctionDeclaration)head;

                sym_table = new FuncSymTab(entries, parent, sub_tables);

                foreach (var parameter in ((ParameterList)function_declaration.parameter_list).parameters)
                {
                    sym_table.addEntry(walk(parameter));
                }
                foreach (var statement in ((StatementList)function_declaration.statement_list).statements)
                {
                    sym_table.addEntry(walk(statement));
                }
                foreach (var statement in ((StatementList)function_declaration.statement_list).statements)
                {
                    sym_table.addSubTable(construct_table(statement, sym_table));
                }
                return sym_table;
            }
            else if (head is IfStatement)
            {
                IfStatement ifStatement = (IfStatement)head;

                sym_table = new IfStatSymTab(entries, parent, sub_tables);

                foreach (var statement in ((StatementList)ifStatement.statement_list).statements)
                {
                    sym_table.addEntry(walk(statement));
                }
                foreach (var statement in ((StatementList)ifStatement.statement_list).statements)
                {
                    sym_table.addSubTable(construct_table(statement, sym_table));
                }
                return sym_table;
            }
            else if (head is WhileStatement)
            {
                WhileStatement whileStat = (WhileStatement)head;

                sym_table = new IfStatSymTab(entries, parent, sub_tables);

                foreach (var statement in ((StatementList)whileStat.statement_list).statements)
                {
                    sym_table.addEntry(walk(statement));
                }
                foreach (var statement in ((StatementList)whileStat.statement_list).statements)
                {
                    sym_table.addSubTable(construct_table(statement, sym_table));
                }
                return sym_table;
            }
            else
            {
                return null;
            }
        }
        public static SymTabEntry walk(Node head)
        {
            if (head is GlobalVarDeclarartion)
            {
                GlobalVarDeclarartion global_var_declaration = (GlobalVarDeclarartion)head;
                return new GVarSymTabEntry(global_var_declaration.id.value, global_var_declaration.datatype.value);
            }
            else if (head is FunctionDeclaration)
            {
                FunctionDeclaration function_declaration = (FunctionDeclaration)head;
                return new FuncSymTabEntry(function_declaration.id.value, function_declaration.return_type.value);
            }
            else if (head is OperationDeclaration)
            {
                OperationDeclaration operation_declaration = (OperationDeclaration)head;
                return new OperSymTabEntry(operation_declaration.operation_name.value);
            }
            else if (head is Parameter)
            {
                Parameter head_parameter = (Parameter)head;

                return new ParamSymTabEntry(head_parameter.parameter_name.GetValue(), head_parameter.parameter_datatype.GetValue());
            }
            else if (head is VarDeclStatement)
            {
                VarDeclStatement var_declaration = (VarDeclStatement)head;
                return new LVarSymTabEntry(var_declaration.id.value, var_declaration.datatype.value);
            }
            else
            {
                return null;
            }
        }
    }
}