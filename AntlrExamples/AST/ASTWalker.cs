using AntlrExamples.Environment;
using AntlrExamples.AST;

namespace AntlrExamples.AST {
    public class ASTWalker {
        public SymbolTable walk(Node root, SymbolTable symbolTable){
            if(root is Program)
            {
                new SymbolTable();
            }else if(root is FunctionDeclaration){

            }else if(root is OperationDeclaration){

            }else if(root is GlobalVarDeclarartion){
                
            }
            return symbolTable;
        }
    }
}