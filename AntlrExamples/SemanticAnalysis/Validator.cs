using System;
using System.Collections.Generic;
using AntlrExamples.Parser;
using AntlrExamples.AST;

namespace AntlrExamples.SemanticAnalysis {
    public static class Validator {
        public static void Validate_TypeMatching(Node root){
            if(root is AST.Program){

            }else if(root is GlobalVarDeclarartion){

            }else if(root is FunctionDeclaration){

            }else if(root is OperationDeclaration){

            }else if(root is VarDeclStatement){

            }else if(root is IfStatement){

            }else if(root is WhileStatement){

            }else if(root is ExprStatement){

            }else if(root is OperationStat){

            }else if(root is ResultStatement){

            }else if(root is ReturnStatement){

            }else if(root is AdditionExpr){

            }else if(root is SubtractionExpr){
                
            }else if(root is MultiplicationExpr){
                
            }else if(root is DivisionExpr){

            }
            else {

            }
        }
    } 
}