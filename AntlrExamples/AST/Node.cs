using System.Collections.Generic;

namespace AntlrExamples.AST {

    public interface INode {
        public List<INode> get_children();
    }
    public class GlobalVarASTN : INode
    {
        string id;
        string type;
        string value;
        public GlobalVarASTN(string _id, string _type, string _value)
        {
            this.id = _id;
            this.type = _type;
            this.value = _value;
        }
        public List<INode> get_children()
        {
            return null;
        }
    }
    public class FunctionDeclASTN : INode
    {
        string id;
        string return_type;
        Dictionary<string, string> parameters;
        List<INode> statements;
        public FunctionDeclASTN(string _id, string _return_type, Dictionary<string, string> _parameters, List<INode> _statements)
        {
            this.id = _id;
            this.return_type = _return_type;
            this.parameters = _parameters;
            this.statements = _statements;
        }
        public List<INode> get_children()
        {
            return statements;
        }
    }
    public class OperationDeclASTN : INode
    {
        string id;
        Dictionary<string, string> parameters;
        List<INode> statements;
        public OperationDeclASTN(string _id, Dictionary<string, string> _parameters, List<INode> _statements)
        {
            this.id = _id;
            this.parameters = _parameters;
            this.statements = _statements;
        }
        public List<INode> get_children()
        {
            return statements;
        }
    }
    public class BinExpr: INode {
        public string op {get;}
        public INode rhs;
        public INode lhs;
        public BinExpr(INode _rhs, INode _lhs){
            this.rhs = _rhs;
            this.lhs = _lhs;
        }
        public List<INode> get_children()
        {
            return new List<INode>() {rhs, lhs};
        }
    }
    public class UnaryExpr:INode {
        public string op{get;}
        public INode operand{get;}
        public List<INode> get_children() {
            return new List<INode>() {operand};
        }
    }
    public interface Expr:INode {
        string get_expr_type();
    }
    
}