using AntlrExamples.AST;
namespace AntlrExamples.Misc {
    public class TreeWalker {
        public INode walk(INode root) {
            if(root is BinExpr){

            }else if(root is UnaryExpr){

            }
            return null;
        }
    }
}