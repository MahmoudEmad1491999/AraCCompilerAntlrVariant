using System;
using Antlr4.Runtime.Tree;
using static AntlrExamples.Parser.aracParser;

namespace AntlrExamples.Environment {
    public class Expression {
        public static string int_expr_datatype(IParseTree int_literal_expr_context){
            var int_literal = ((Int_literal_exprContext) int_literal_expr_context).int_literal();
            string int_size = int_literal.children[int_literal.ChildCount - 1].GetText();
            if(int_literal.PLUS() != null){
                if( int_size == "١"){
                    return "طبيعي_١";
                }else if(int_size == "٢"){
                    return "طبيعي_٢";
                }else if(int_size == "٤"){
                    return "طبيعي_٤";
                }else if(int_size == "٨"){
                    return "طبيعي_٨";
                }else {
                    throw new Exception("This path Should be un-reachable");
                }
            }else {
                if( int_size == "١"){
                    return "صحيح_١";
                }else if(int_size == "٢"){
                    return "صحيح_٢";
                }else if(int_size == "٤"){
                    return "صحيح_٤";
                }else if(int_size == "٨"){
                    return "صحيح_٨";
                }else {
                    throw new Exception("This path Should be un-reachable");
                }
            }
        }
        public static string get_expr_type(IParseTree expr, SymTab symtab){
            if(expr is Int_literal_exprContext){
                var int_literal_expr = (Int_literal_exprContext) expr;
                var datatype = Expression.int_expr_datatype(int_literal_expr);
                return datatype;
            }
            else if(expr is Variable_exprContext){
                var variable_expr = (Variable_exprContext) expr;
                string identifier = variable_expr.ID().GetText();
                if(symtab.is_symbol_reserved(identifier)){ 
                    var entry = symtab.get_symbol_entry_by_id(identifier);

                    if(entry.sym_type != SymType.LOCAL_VARIABLE && entry.sym_type != SymType.GLOBAL_VARIABLE){
                        throw new Exception("Symbol is not a variable!");
                    }
                    else if(entry.sym_type == SymType.LOCAL_VARIABLE){
                        var variable_entry = (LVarSymTabEntry) entry;
                        var var_datatype = variable_entry.data_type;

                        return var_datatype;
                    }else if(entry.sym_type == SymType.GLOBAL_VARIABLE){
                        var variable_entry = (GVarSymTabEntry) entry;
                        var var_datatype = variable_entry.data_type;
                    
                        return var_datatype;
                    }
                }
                else {
                    throw new Exception("undeclared variable!");
                }
            }
            else if(expr is Add_exprContext){
                var add_expr = (Add_exprContext) expr;
                var datatype = get_expr_type(add_expr.expression()[0], symtab);
                
                return datatype;
            }
            else if(expr is Subtraction_exprContext){
                var subtraction_expr = (Subtraction_exprContext) expr;
                var datatype = get_expr_type(subtraction_expr.expression()[0], symtab);
                
                return datatype;
            }
            else if(expr is Multiply_exprContext){
                var multiply_expr = (Multiply_exprContext) expr;
                var datatype = get_expr_type(multiply_expr, symtab);
                
                return datatype;
            }
            else if(expr is Divide_exprContext){
                var division_expr = (Divide_exprContext) expr;
                var datatype = get_expr_type(division_expr, symtab);
                
                return datatype;
            }
            else if(expr is Parenthesis_exprContext) {
                return get_expr_type(((Parenthesis_exprContext)expr).expression(), symtab);
            }else if(expr is Lnot_exprContext){
                return "صحيح_١";
            }else if(expr is Minus_exprContext){
                var datatype = get_expr_type(((Minus_exprContext) expr).expression(), symtab);
                if(datatype == "طبيعي_١"){
                    return "صحيح_١";
                }else if(datatype == "طبيعي_٢"){
                    return "صحيح_٢";
                }else if(datatype == "طبيعي_٤"){
                    return "صحيح_٤";
                }else if(datatype == "طبيعي_٨"){
                    return "صحيح_٨";
                }else {return datatype;}
            }
            else if(expr is Fun_call_exprContext){
                var func_call_expr = (Fun_call_exprContext) expr;
                var function_name = func_call_expr.ID().GetText();
                var function_entry_in_symtable = symtab.get_symbol_entry_by_id(function_name);
                if(function_entry_in_symtable.sym_type != SymType.FUNCTION){
                    throw new Exception("The symbol is not a function");
                }else {
                    return ((FuncSymTabEntry) function_entry_in_symtable).return_type;
                }
            }else if(expr is Lnot_exprContext || expr is Lor_exprContext || expr is Land_exprContext){
                return "صحيح_١";
            }else if(expr is Comparison_exprContext){
                return "صحيح_١";
            }else if(expr is Equality_exprContext){
                return "صحيح_١";
            }
            return null;
        }
        
    }
}