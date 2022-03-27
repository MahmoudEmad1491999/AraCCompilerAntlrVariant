// using System;
// using System.IO;
// namespace AntlrExamples.AST
// {
//     public enum BinArithmOp
//     {
//         ADD,
//         SUB,
//         MULT,
//         DIVIDE,
//         MODULS
//     }
//     public enum UnaryArithmOp
//     {
//         NEGATIVE
//     }
//     public enum BinLogOp
//     {
//         AND,
//         OR
//     }
//     public enum UnaryLogOp
//     {
//         NOT
//     }
//     public enum CompOp
//     {
//         EQL,
//         NEQL,
//         LT,
//         GT,
//         LTQ,
//         GTQ
//     }
//     public enum BinBitOp
//     {
//         BAND,
//         BOR,
//         BXOR,
//         SLL,
//         SRL,
//         SRA,
//     }
//     public enum UnaryBitOp
//     {
//         BNOT
//     }

//     public class BinArithExpr : Expr
//     {
//         public string type { get; }
//         public Expr rhs { get; }
//         public Expr lhs { get; }
//         BinArithmOp op { get; }
//         public BinArithExpr(BinArithmOp _op, Expr _rhs, Expr _lhs, string _type)
//         {
//             if(_rhs.get_expr_type() != _lhs.get_expr_type()){
//                 throw new ArgumentException("type mismatch between the right hand side and the left hand side of the operation.");
//             }
//             this.rhs = _rhs;
//             this.lhs = _lhs;
//             this.op = _op;
//             this.type = _type;
//         }

//         public string get_expr_type()
//         {
//             throw new NotImplementedException();
//         }
//     }
//     public class UnaryArithExpr : Expr
//     {
//         public UnaryArithmOp op { get; }
//         public Expr operand { get; }
//         public UnaryArithExpr(UnaryArithmOp _op, Expr _operand)
//         {
//             this.op = _op;
//             this.operand = _operand;
//         }

//         public string get_expr_type()
//         {
//             throw new System.NotImplementedException();
//         }
//     }
//     public class BinaryLogiExpr : Expr
//     {
//         public string type { get; }
//         public Expr rhs { get; }
//         public Expr lhs { get; }
//         public BinLogOp op { get; }
//         public BinaryLogiExpr(BinLogOp _op, Expr _rhs, Expr _lhs, string _type)
//         {
//             this.rhs = _rhs;
//             this.lhs = _lhs;
//             this.op = _op;
//             this.type = _type;
//         }

//         public string get_expr_type()
//         {
//             throw new System.NotImplementedException();
//         }
//     }
//     public class UnaryLogExpr : Expr
//     {
//         public UnaryLogOp op { get; }
//         public Expr operand { get; }
//         public UnaryLogExpr(UnaryLogOp _op, Expr _operand)
//         {
//             this.op = _op;
//             this.operand = _operand;
//         }

//         public string get_expr_type()
//         {
//             throw new System.NotImplementedException();
//         }
//     }
//     public class CompExpr : Expr
//     {
//         public CompOp op { get; }
//         public Expr lhs { get; }
//         public Expr rhs { get; }

//         public CompExpr(CompOp _op, Expr _lhs, Expr _rhs)
//         {
//             this.op = _op;
//             this.lhs = _lhs;
//             this.rhs = _rhs;
//         }

//         public string get_expr_type()
//         {
//             throw new System.NotImplementedException();
//         }
//     }
//     public class BinBitExpr : Expr
//     {
//         public BinBitOp op { get; }
//         public Expr lhs { get; }
//         public Expr rhs { get; }

//         public BinBitExpr(BinBitOp _op, Expr _lhs, Expr _rhs)
//         {
//             this.op = _op;
//             this.lhs = _lhs;
//             this.rhs = _rhs;
//         }

//         public string get_expr_type()
//         {
//             throw new System.NotImplementedException();
//         }
//     }
//     public class UnaryBitExpr : Expr
//     {
//         public UnaryBitOp op { get; }
//         public Expr operand { get; }
//         public UnaryBitExpr(UnaryBitOp _op, Expr _operand)
//         {
//             this.op = _op;
//             this.operand = _operand;
//         }

//         public string get_expr_type()
//         {
//             throw new System.NotImplementedException();
//         }
//     }
//     public class AddOfExp : Expr {
//         public Expr operand { get;}
//         public AddOfExp(Expr _operand) {
//             this.operand = _operand;
//         }

//         public string get_expr_type()
//         {
//             throw new System.NotImplementedException();
//         }
//     }
//     public class ValueInside: Expr {
//         public Expr operand {get;}
//         public ValueInside(Expr _operand) {
//             this.operand = _operand;
//         }

//         public string get_expr_type()
//         {
//             throw new System.NotImplementedException();
//         }
//     }
// }