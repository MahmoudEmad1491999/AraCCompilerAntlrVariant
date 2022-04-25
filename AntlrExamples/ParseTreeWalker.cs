using Antlr4.Runtime.Tree;
using static AntlrExamples.Parser.aracParser;
using AntlrExamples.Environment;
using System.Collections.Generic;
using System;

namespace AntlrExamples {
    public static class ParseTreeWalker {
        public static SymTab GenerateTable(IParseTree root, SymTab parent) {
            SymTab result;
            if(root is ProgramContext){
                var programContext = (ProgramContext) root;
                result = new ProgramSymTab(null);
                for(int index = 0; index < programContext.ChildCount; index++) 
                {
                    result.addEntry(GenerateEntry(programContext.children[index]));
                }
                for(int index = 0; index < programContext.ChildCount; index++)
                {
                    result.addSubTable(GenerateTable(programContext.children[index],result));
                }
                return result;
            }else if(root is GlobalVarDeclContext){
                var globalVarDeclContext = (GlobalVarDeclContext) root;
                string var_datatype = globalVarDeclContext.dataType().GetText();
                string initialization_datatype = Expression.get_expr_type(globalVarDeclContext.inititalization().expression(),parent);
                if(var_datatype != initialization_datatype)
                {
                    throw new System.Exception($"Type mismatch:\nglobal_var_type: {var_datatype}\ninitializor_datatype: {initialization_datatype}" );
                }
                return null;
            }
            else if(root is FunctionDeclContext){
                var function_decl = (FunctionDeclContext) root;
                result = new FuncSymTab(parent, function_decl.ID().GetText());
                var parameters = function_decl.paramList().parameter();
                var statements = function_decl.statementList().statement();
                for(int index = 0; index < parameters.Length; index++){
                    result.addEntry(GenerateEntry(parameters[index]));
                }
                for(int index = 0; index < statements.Length; index++)
                {
                    result.addEntry(GenerateEntry(statements[index]));
                }
                for(int index = 0; index < parameters.Length; index++){
                    result.addSubTable(GenerateTable(parameters[index], result));
                }
                for(int index = 0; index < statements.Length; index++)
                {
                    result.addSubTable(GenerateTable(statements[index], result));
                }
                return result;
            }else if(root is OperationDeclContext){
                var operation_decl = (OperationDeclContext) root;
                result  = new OperSymTab(parent);
                var parameters = operation_decl.paramList().parameter();
                var statements = operation_decl.statementList().statement();
                for(int index = 0; index < parameters.Length; index++){
                    result.addEntry(GenerateEntry(parameters[index]));
                }
                for(int index = 0; index < statements.Length; index++)
                {
                    result.addEntry(GenerateEntry(statements[index]));
                }
                for(int index = 0; index < parameters.Length; index++){
                    result.addSubTable(GenerateTable(parameters[index], result));
                }
                for(int index = 0; index < statements.Length; index++)
                {
                    result.addSubTable(GenerateTable(statements[index], result));
                }
            }else if( root is Var_DeclContext){
                var var_decl = ((Var_DeclContext) root).varDecl();
                var var_datatype = var_decl.dataType().GetText();
                var initialization_datatype = Expression.get_expr_type(var_decl.inititalization().expression(), parent);
                if(var_datatype != initialization_datatype)
                {
                    throw new System.Exception($"Type mismatch:\nglobal_var_type: {var_datatype}\ninitializor_datatype: {initialization_datatype}" );
                }
                return null;
            }else if(root is Result_StatContext){
                var result_stat = ((Result_StatContext) root).resultStat();
                var result_datatype = Expression.get_expr_type(result_stat.expression(), parent);
                SymTab temp = parent;
                while(temp.sym_tab_type != SymTabType.FUNCTION && temp.sym_tab_type != SymTabType.FILE){
                    temp = temp.parent;
                }
                if(temp.sym_tab_type != SymTabType.FUNCTION){
                    throw new Exception($"result statment should only be used inside function scopes. scopetype: {temp.sym_tab_type}" );
                }
                var function_name = ((FuncSymTab) temp).function_name;
                temp = temp.parent;
                var function_return_type = ((FuncSymTabEntry)temp.get_symbol_entry_by_id(function_name)).return_type;

                if(function_return_type != result_datatype) {
                    throw new Exception("Type mismatch between the result datatype and enclosing function datatype");
                }
                return null;
            }else if(root is Assignment_StatContext){
                var assignment_stat = ((Assignment_StatContext) root).assignmentStat();
                var var_name = assignment_stat.ID().GetText();
                var expression_datatype = Expression.get_expr_type(assignment_stat.expression(), parent);
                string var_datatype = null;
                SymTabEntry entry = parent.get_symbol_entry_by_id(var_name);
                if(
                    entry.sym_type != SymType.LOCAL_VARIABLE && 
                    entry.sym_type != SymType.GLOBAL_VARIABLE && 
                    entry.sym_type != SymType.PARAMETER
                    ){
                    throw new Exception("cannot assign value to symbol of type: " + entry.sym_type);
                }else {
                    if(entry.sym_type == SymType.GLOBAL_VARIABLE)
                    {
                        var global_var_decl = (GVarSymTabEntry) entry;
                        var_datatype = global_var_decl.data_type;
                    }else if(entry.sym_type == SymType.LOCAL_VARIABLE){
                        var local_var_decl = (LVarSymTabEntry) entry;
                        var_datatype = local_var_decl.data_type;
                    }else if(entry.sym_type == SymType.PARAMETER){
                        var parameter = (GVarSymTabEntry) entry;
                        var_datatype = parameter.data_type;
                    }
                }
                if(expression_datatype != var_datatype){
                    throw new Exception($"Type Mismatch: {var_datatype} differs from {expression_datatype}");
                }
                return null;
            }
            return null;
        }

        

        public static SymTabEntry GenerateEntry(IParseTree node){
            if(node is GlobalVarDeclContext){
                var global_var_decl = (GlobalVarDeclContext) node;
                return new GVarSymTabEntry(global_var_decl.ID().GetText(), global_var_decl.dataType().GetText());
            }else if(node is FunctionDeclContext){
                var func_decl = (FunctionDeclContext) node;
                return new FuncSymTabEntry(func_decl.ID().GetText(), func_decl.dataType().GetText());
            }else if(node is ParameterContext){
                var parameter = (ParameterContext) node;
                return new ParamSymTabEntry(parameter.ID().GetText(), parameter.dataType().GetText());
            }else if(node is Var_DeclContext){
                var var_decl = ((Var_DeclContext) node).varDecl();
                return new LVarSymTabEntry(var_decl.ID().GetText(), var_decl.dataType().GetText());
            }
            return null;
        }
    }
}