using System;
using System.Collections.Generic;
namespace AntlrExamples.AST {
    
    public enum ComparisonOperator
    {
        GREATER_THAN,
        LESS_THAN,
        GREATER_THAN_EQUAL,
        LESS_THAN_EQUAL,
    }

    public abstract class Node
    {
        public int child_count = 0;
        public abstract Node GetChild(int index);
        public abstract string GetValue();
    }
    public abstract class statement : Node { }
    public abstract class Expression : Node { }
    public abstract class Literal : Expression
    {
        public string literal;
        public Literal(string literal)
        {
            this.literal = literal;
        }
    }
    public class Identifier : Node
    {
        public string id;
        public Identifier(string id)
        {
            this.id = id;
            this.child_count = 0;
        }
        public override Node GetChild(int index)
        {
            throw new Exception("Node does not have children;");
        }
        public override string GetValue()
        {
            return this.id;
        }
    }
    public class Program : Node
    {
        public List<Node> declarations;

        public Program(List<Node> declarations)
        {
            this.declarations = declarations;
            this.child_count = declarations.Count;
        }
        public override Node GetChild(int index)
        {
            if (index < this.child_count)
            {
                return this.declarations[index];
            }
            else
            {
                throw new Exception("index out of range!");
            }
        }
        public override string GetValue()
        {
            return "Program";
        }
    }
    public class FunctionDeclaration : Node
    {
        public Identifier return_type;
        public Identifier id;
        public Node parameter_list;
        public Node statement_list;
        public List<Node> children;
        public FunctionDeclaration(Identifier return_type, Identifier id, Node parameter_list, Node statement_list)
        {
            this.id = id;
            this.return_type = return_type;
            this.parameter_list = parameter_list;
            this.statement_list = statement_list;
            this.children = new List<Node>(){
                return_type,
                id,
                parameter_list,
                statement_list
            };
            this.child_count = 4;

        }

        public override Node GetChild(int index)
        {
            if (index < child_count)
            {
                return this.children[index];
            }
            else
            {
                throw new Exception("Index out of range!");
            }
        }

        public override string GetValue()
        {
            return "FunctionDeclaration";
        }
    }
    public class OperationDeclaration : Node
    {
        public Identifier operation_name;
        public Node parameter_list;
        public Node statement_list;
        public List<Node> children;
        public OperationDeclaration(Identifier operation_name, Node parameter_list, Node statement_list)
        {
            this.operation_name = operation_name;
            this.parameter_list = parameter_list;
            this.statement_list = statement_list;
            this.children = new List<Node>(){
                operation_name,
                parameter_list,
                statement_list
            };
            this.child_count = 3;
        }

        public override Node GetChild(int index)
        {
            if (index < child_count)
            {
                return this.children[index];
            }
            else
            {
                throw new Exception("Index out of range!");
            }
        }

        public override string GetValue()
        {
            return "OperationDeclaration";
        }
    }
    public class GlobalVarDeclarartion : Node
    {
        public Identifier datatype;
        public Identifier id;
        public Node initial_value;
        public List<Node> children;
        public GlobalVarDeclarartion(Identifier datatype, Identifier id, Node initial_value)
        {
            this.datatype = datatype;
            this.id = id;
            this.initial_value = initial_value;
            if (initial_value != null)
            {
                this.children = new List<Node>(){
                    datatype,
                    id,
                    initial_value
                };
            }
            else
            {
                this.children = new List<Node>(){
                    datatype,
                    id
                };
            }

            this.child_count = children.Count;
        }

        public override Node GetChild(int index)
        {
            if (index < child_count)
            {
                return this.children[index];
            }
            else
            {
                throw new Exception("Index out of range!");
            }
        }

        public override string GetValue()
        {
            return "GlobalVarDeclarartion";
        }
    }

    public class AssignStatment : statement
    {
        public Identifier variable_name;
        public Node value;
        public List<Node> children;
        public AssignStatment(Identifier variable_name, Node value)
        {
            this.variable_name = variable_name;
            this.value = value;
            this.children = new List<Node>(){
                variable_name,
                value
            };
            this.child_count = 2;

        }
        public override Node GetChild(int index)
        {
            if (index < child_count)
            {
                return children[index];
            }
            else
            {
                throw new Exception("index out of bound!");
            }
        }
        public override string GetValue()
        {
            return "AssignStatment";
        }
    }
    public class IfStatement : statement
    {
        public Node condition;
        public Node statement_list;
        public List<Node> children;
        public IfStatement(Node condition, Node statement_list)
        {
            this.condition = condition;
            this.statement_list = statement_list;
            this.children = new List<Node>(){
                condition,
                statement_list
            };
            child_count = 2;
        }

        public override string GetValue()
        {
            return "IfStatement";
        }

        public override Node GetChild(int index)
        {
            if (index < child_count)
            {
                return this.children[index];
            }
            else
            {
                throw new Exception("index out of bounds!");
            }
        }
    }
    public class WhileStatement : statement
    {
        public Node condition;
        public Node statement_list;
        public List<Node> children;
        public WhileStatement(Node condition, Node statement_list)
        {
            this.condition = condition;
            this.statement_list = statement_list;

            this.children = new List<Node>(){
                condition,
                statement_list
            };
            this.child_count = 2;
        }

        public override Node GetChild(int index)
        {
            if (index < child_count)
            {
                return children[index];
            }
            else
            {
                throw new Exception("index out of bounds!");
            }
        }

        public override string GetValue()
        {
            return "WhileStatement";
        }
    }
    public class ReturnStatement : statement
    {
        public ReturnStatement()
        {
            this.child_count = 0;
        }
        public override Node GetChild(int index)
        {
            throw new Exception("node should not have any children nodes1");
        }

        public override string GetValue()
        {
            return "ReturnStatement";
        }
    }
    public class ResultStatement : statement
    {
        public Node return_value;
        public ResultStatement(Node return_value)
        {
            this.return_value = return_value;
            this.child_count = 1;
        }

        public override Node GetChild(int index)
        {
            if (index < child_count)
            {
                return return_value;
            }
            else
            {
                throw new Exception("Index out of bounds");
            }
        }

        public override string GetValue()
        {
            return "ResultStatement";
        }
    }
    public class VarDeclStatement : statement
    {
        public Identifier datatype;
        public Identifier id;
        public Node value;
        public List<Node> children;

        public VarDeclStatement(Identifier datatype, Identifier id, Node value)
        {
            this.datatype = datatype;
            this.id = id;
            this.value = value;
            if (value != null)
            {
                this.children = new List<Node>()
                {
                    datatype,
                    id,
                    value
                };
            }
            else
            {
                this.children = new List<Node>()
                {
                    datatype,
                    id,
                };

            }
            this.child_count = children.Count;


        }

        public override Node GetChild(int index)
        {

            if (index < child_count)
            {
                return children[index];
            }
            else
            {
                throw new Exception("index out of bounds!");
            }
        }

        public override string GetValue()
        {
            return "VarDeclStatement";
        }
    }
    public class ExprStatement : statement
    {
        public Node expr;
        public ExprStatement(Node expr)
        {
            this.expr = expr;
            this.child_count = 1;
        }

        public override Node GetChild(int index)
        {
            if (index < child_count)
            {
                return expr;
            }
            else
            {
                throw new Exception("index out of bounds!");
            }
        }

        public override string GetValue()
        {
            return "ExprStatement";
        }
    }
    public class AdditionExpr : Expression
    {
        public Node first_operand;
        public Node second_operand;
        public List<Node> children;

        public AdditionExpr(Node first_operand, Node second_operand)
        {
            this.first_operand = first_operand;
            this.second_operand = second_operand;
            children = new List<Node>() {
                first_operand,
                second_operand
            };
            this.child_count = 2;
        }

        public override Node GetChild(int index)
        {
            if (index < child_count)
            {
                return children[index];
            }
            else
            {
                throw new Exception("index out of bounds!");
            }
        }

        public override string GetValue()
        {
            return "AdditionExpr";
        }
    }
    public class SubtractionExpr : Expression
    {
        public Node first_operand;
        public Node second_operand;
        public List<Node> children;

        public SubtractionExpr(Node first_operand, Node second_operand)
        {
            this.first_operand = first_operand;
            this.second_operand = second_operand;
            children = new List<Node>(){
                first_operand,
                second_operand
            };

            this.child_count = 2;
        }

        public override Node GetChild(int index)
        {
            if (index < child_count)
            {
                return children[index];
            }
            else
            {
                throw new Exception("Index out of bounds!");
            }
        }

        public override string GetValue()
        {
            return "SubtractionExpr";
        }
    }
    public class OperationStat : statement
    {
        public Identifier operation_name;
        public Node argument_list;
        public List<Node> children;
        public OperationStat(Identifier operation_name, Node argument_list)
        {
            this.operation_name = operation_name;
            this.argument_list = argument_list;
            this.children = new List<Node>(){
                operation_name,
                argument_list
            };
            this.child_count = 2;

        }

        public override Node GetChild(int index)
        {
            if (index < child_count)
            {
                return children[index];
            }
            else
            {
                throw new Exception("Index out of bounds!");
            }
        }

        public override string GetValue()
        {
            return "OperationStat";
        }
    }
    public class MultiplicationExpr : Expression
    {
        public Node first_operand;
        public Node second_operand;
        public List<Node> children;
        public MultiplicationExpr(Node first_operand, Node second_operand)
        {
            this.first_operand = first_operand;
            this.second_operand = second_operand;
            children = new List<Node>(){
                first_operand, second_operand
            };
            this.child_count = 2;
        }

        public override Node GetChild(int index)
        {
            if (index < child_count)
            {
                return children[index];
            }
            else
            {
                throw new Exception("Index out of bounds!");
            }
        }

        public override string GetValue()
        {
            return "MultiplicationExpr";
        }
    }

    public class DivisionExpr : Node
    {
        public Node first_operand;
        public Node second_operand;
        public List<Node> children;

        public DivisionExpr(Node first_operand, Node second_operand)
        {
            this.first_operand = first_operand;
            this.second_operand = second_operand;
            children = new List<Node>(){
                first_operand, second_operand
            };
            this.child_count = 2;
        }

        public override Node GetChild(int index)
        {
            if (index < child_count)
            {
                return children[index];
            }
            else
            {
                throw new Exception("Index out of bounds!");
            }
        }

        public override string GetValue()
        {
            return "DivisionExpr";
        }
    }
    public class FunctionCallExpr : Node
    {
        public string function_name;
        public Node argument_list;
        public List<Node> children;

        public FunctionCallExpr(string function_name, Node argument_list)
        {
            this.function_name = function_name;
            this.argument_list = argument_list;
            this.children = new List<Node>();
            this.children = new List<Node>(){
                argument_list
            };
            this.child_count = 1;
        }

        public override Node GetChild(int index)
        {
            if (index < child_count)
            {
                return children[index];
            }
            else
            {
                throw new Exception("Index out of bounds!");
            }
        }

        public override string GetValue()
        {
            return "FunctionCallExpr: " + this.function_name;
        }
    }
    public class NegatedExpression : Node
    {
        public Node expr;
        public NegatedExpression(Node expr)
        {
            this.expr = expr;
            this.child_count = 1;
        }

        public override Node GetChild(int index)
        {
            if (index < child_count)
            {
                return expr;
            }
            else
            {
                throw new Exception("Index out of bounds!");
            }
        }

        public override string GetValue()
        {
            return "NegatedExpression";
        }
    }
    public class IntLiteralExpr : Literal
    {
        public IntLiteralExpr(string literal) : base(literal)
        {
            this.child_count = 0;
        }

        public override Node GetChild(int index)
        {

            throw new Exception("Index out of bounds!");

        }

        public override string GetValue()
        {
            Char[] characters = literal.ToCharArray();
            Array.Reverse(characters);

            return "IntLiteralExpr: " + new string(characters);
        }
    }

    public class VariableExpr : Expression
    {
        public string variable_name;
        public VariableExpr(string variable_name)
        {
            this.variable_name = variable_name;
            this.child_count = 0;
        }

        public override Node GetChild(int index)
        {
            throw new Exception("Index Out Of bounds: VariableExpr");
        }

        public override string GetValue()
        {
            return "VariableExpr: " + variable_name;
        }
    }
    public class ParenthesisExpr : Node
    {
        public Node expr;
        public ParenthesisExpr(Node expr)
        {
            this.expr = expr;
            this.child_count = 1;
        }

        public override Node GetChild(int index)
        {
            if (index < child_count)
            {
                return this.expr;
            }
            else
            {
                throw new Exception("Index out of bounds!");
            }
        }

        public override string GetValue()
        {
            return "ParenthesisExpr";
        }
    }

    public class StatementList : Node
    {
        public List<Node> statements;
        public List<Node> children;
        public StatementList(List<Node> statements)
        {
            this.statements = statements;
            children = statements;
            this.child_count = children.Count;
        }

        public override Node GetChild(int index)
        {
            if (index < child_count)
            {
                return children[index];
            }
            else
            {
                throw new Exception("Index out of bounds!");
            }
        }

        public override string GetValue()
        {
            return "StatementList";
        }
    }
    public class Argument : Node
    {
        public Node arugument_expr;
        public Argument(Node argument_expr)
        {
            this.arugument_expr = argument_expr;
            this.child_count = 1;
        }

        public override Node GetChild(int index)
        {
            if (index < child_count)
            {
                return this.arugument_expr;
            }
            else
            {
                throw new Exception("Index out of bounds!");
            }
        }

        public override string GetValue()
        {
            return "Argument";
        }
    }
    public class ArgumentList : Node
    {
        public List<Node> arguments;
        public List<Node> children;
        public ArgumentList(List<Node> arguments)
        {
            this.arguments = arguments;
            this.children = arguments;
            this.child_count = arguments.Count;
        }

        public override Node GetChild(int index)
        {
            if (index < child_count)
            {
                return children[index];
            }
            else
            {
                throw new Exception("Index out of bounds!");
            }
        }

        public override string GetValue()
        {
            return "ArgumentList";
        }
    }

    public class Parameter : Node
    {
        public Node parameter_datatype;
        public Node parameter_name;
        public List<Node> children;
        public Parameter(Node parameter_name, Node parameter_datatype)
        {
            this.parameter_datatype = parameter_datatype;
            this.parameter_name = parameter_name;
            children = new List<Node>(){
                parameter_datatype, parameter_name
            };
            this.child_count = 2;


        }

        public override Node GetChild(int index)
        {
            if (index < child_count)
            {
                return children[index];
            }
            else
            {
                throw new Exception("Index out of bounds!");
            }
        }

        public override string GetValue()
        {
            return "Parameter";
        }
    }
    public class ParameterList : Node
    {
        public List<Node> parameters;
        public List<Node> children;
        public ParameterList(List<Node> parameters)
        {
            this.parameters = parameters;
            children = parameters;
            this.child_count = parameters.Count;
        }

        public override Node GetChild(int index)
        {
            if (index < child_count)
            {
                return children[index];
            }
            else
            {
                throw new Exception("Index out of bounds!");
            }
        }

        public override string GetValue()
        {
            return "ParameterList";
        }
    }
    public class CompExpression : Expression
    {
        public Node first_operand;
        public string comp_op;
        public Node second_operand;
        public List<Node> children;
        public CompExpression(Node first_operand, string comp_op, Node second_operand)
        {
            this.first_operand = first_operand;

            this.comp_op = comp_op;

            this.second_operand = second_operand;

            children = new List<Node>() {
                first_operand,
                second_operand
            };

            this.child_count = children.Count;
        }

        public override Node GetChild(int index)
        {
            if (index < child_count)
            {
                return children[index];
            }
            else
            {
                throw new Exception("Index out of range!");
            }
        }

        public override string GetValue()
        {
            return "CompExpression: " + comp_op;
        }
    }
    public class UnaryBLExpression : Expression
    {
        public Node operand;
        public string operation;
        public UnaryBLExpression(Node operand, string operation)
        {
            this.operand = operand;
            this.operation = operation;
            child_count = 1;
        }

        public override Node GetChild(int index)
        {
            if (index < child_count)
            {
                return operand;
            }
            else
            {
                throw new Exception("Index out of Range!");
            }
        }

        public override string GetValue()
        {
            return "UnaryBLExpression " + this.operation;
        }
    }
    public class CastingExpression : Node
    {
        public string datatype;
        public Node expr;
        public CastingExpression(string datatype, Node expr)
        {
            this.datatype = datatype;
            this.expr = expr;
            this.child_count = 1;
        }

        public override Node GetChild(int index)
        {
            if (index < child_count)
            {
                return expr;
            }
            else
            {
                throw new Exception("Index out of range");
            }
        }

        public override string GetValue()
        {
            return "CastingExpression: " + datatype;
        }
    }
    public class EqualityExpression : Node
    {
        public Node first_operand;
        public string operation;
        public Node second_operand;
        public List<Node> children;
        public EqualityExpression(Node first_operand, string operation, Node second_operand)
        {
            this.first_operand = first_operand;
            this.operation = operation;
            this.second_operand = second_operand;

            children = new List<Node>(){
                first_operand, second_operand
            };

            this.child_count = 2;
        }

        public override Node GetChild(int index)
        {
            if (index < children.Count)
            {
                return children[index];
            }
            else
            {
                throw new Exception("Index out of range!");
            }
        }

        public override string GetValue()
        {
            return "EqualityExpression: " + this.operation;
        }
    }

    public class BOrExpression : Node
    {
        public Node first_operand;
        public Node second_operand;
        public List<Node> children;
        public BOrExpression(Node first_operand, Node secon_operand)
        {
            this.first_operand = first_operand;
            this.second_operand = secon_operand;

            children = new List<Node>(){
                first_operand,
                secon_operand
            };
            this.child_count = 2;

        }

        public override Node GetChild(int index)
        {
            if (index < child_count)
            {
                return children[index];
            }
            else
            {
                throw new Exception("Index out of range!");
            }
        }

        public override string GetValue()
        {
            return "Bitwise Or Expression";
        }
    }
    public class BXorExpression : Node
    {
        public Node first_operand;
        public Node second_operand;
        public List<Node> children;
        public BXorExpression(Node first_operand, Node secon_operand)
        {
            this.first_operand = first_operand;
            this.second_operand = secon_operand;

            children = new List<Node>(){
                first_operand,
                secon_operand
            };
            this.child_count = 2;

        }

        public override Node GetChild(int index)
        {
            if (index < child_count)
            {
                return children[index];
            }
            else
            {
                throw new Exception("Index out of range!");
            }
        }

        public override string GetValue()
        {
            return "Bitwise Xor Expression";
        }
    }
    public class BAndExpression : Node
    {
        public Node first_operand;
        public Node second_operand;
        public List<Node> children;
        public BAndExpression(Node first_operand, Node secon_operand)
        {
            this.first_operand = first_operand;
            this.second_operand = secon_operand;

            children = new List<Node>(){
                first_operand,
                secon_operand
            };
            this.child_count = 2;

        }

        public override Node GetChild(int index)
        {
            if (index < child_count)
            {
                return children[index];
            }
            else
            {
                throw new Exception("Index out of range!");
            }
        }

        public override string GetValue()
        {
            return "Bitwise And Expression";
        }
    }
    public class LandExpression : Node
    {
        public Node first_operand;
        public Node second_operand;
        public List<Node> children;
        public LandExpression(Node first_operand, Node second_operand)
        {
            this.first_operand = first_operand;
            this.second_operand = second_operand;
            children = new List<Node>() {
                first_operand,
                second_operand
            };
            this.child_count = 2;
        }

        public override Node GetChild(int index)
        {
            if (index < child_count)
            {
                return children[index];
            }
            else
            {
                throw new Exception("Index out of range");
            }
        }

        public override string GetValue()
        {
            return "Logical And Expression";
        }
    }
    public class LorExpression : Node
    {
        public Node first_operand;
        public Node second_operand;
        public List<Node> children;
        public LorExpression(Node first_operand, Node second_operand)
        {
            this.first_operand = first_operand;
            this.second_operand = second_operand;
            children = new List<Node>() {
                first_operand,
                second_operand
            };
            this.child_count = 2;
        }

        public override Node GetChild(int index)
        {
            if (index < child_count)
            {
                return children[index];
            }
            else
            {
                throw new Exception("Index out of range");
            }
        }

        public override string GetValue()
        {
            return "Logical or Expression";
        }
    }
    public class ArraySubscriptionExpression : Node
    {
        public Node arr_expr;
        public Node index_expr;
        public List<Node> children;
        public ArraySubscriptionExpression(Node arr_expr, Node index_expr)
        {
            this.arr_expr = arr_expr;
            this.index_expr = index_expr;
            children = new List<Node>(){
                arr_expr,
                index_expr
            };
            this.child_count = children.Count;
        }

        public override Node GetChild(int index)
        {
            if (index < child_count)
            {
                return children[index];
            }
            else
            {
                throw new Exception("Index out of range");
            }
        }

        public override string GetValue()
        {
            return "Array subscription expression";
        }
    }
    
    
    public class AddressExpression : Node {
        public Node operand;
        public AddressExpression(Node operand)
        {
            this.operand = operand;
            this.child_count = 1;
        }

        public override Node GetChild(int index)
        {
            if(index < child_count){
                return this.operand;
            }else {
                throw new Exception("index out of range");
            }
        }

        public override string GetValue()
        {
            return "AddressExpression";
        }
    }
    public class IndirectionExpression : Node {
        public Node operand;
        public IndirectionExpression(Node operand){
            this.operand = operand;
            this.child_count = 1;
        }

        public override Node GetChild(int index)
        {
            if(index < child_count){
                return this.operand;
            }else {
                throw new Exception("Index out of range");
            }
        }

        public override string GetValue()
        {
            return "IndirectionExpression";
        }
    }
    public class SizeExpression: Node {
        public Node expression;
        public SizeExpression(Node expression){
            this.expression = expression;
            this.child_count = 1;
        }

        public override Node GetChild(int index)
        {
            if(index < child_count){
                return expression;
            }else {
                throw new Exception("Index out of range");
            }
        }

        public override string GetValue()
        {
            return "Size Expression";
        }
    }
    public class ShiftLeftExpression: Node {
        public Node first_operand;
        public Node second_operand;
        public List<Node> children;
        public ShiftLeftExpression(Node first_operand, Node second_operand)
        {
            this.first_operand = first_operand;
            this.second_operand = second_operand;
            this.child_count = 2;
            children = new List<Node>(){
                first_operand,
                second_operand
            };
        }

        public override Node GetChild(int index)
        {
            if(index < child_count)
            {
                return children[index];
            }else {
                throw new Exception("Index out of range");
            }
        }

        public override string GetValue()
        {
            return "Shift Left Expression";
        }
    }
    public class ShiftRightExpression: Node {
        public Node first_operand;
        public Node second_operand;
        public List<Node> children;
        public ShiftRightExpression(Node first_operand, Node second_operand)
        {
            this.first_operand = first_operand;
            this.second_operand = second_operand;
            this.child_count = 2;
            children = new List<Node>(){
                first_operand,
                second_operand
            };
        }

        public override Node GetChild(int index)
        {
            if(index < child_count)
            {
                return children[index];
            }else {
                throw new Exception("Index out of range");
            }
        }

        public override string GetValue()
        {
            return "Shift RightShiftRightExprContext Expression";
        }
    }
}