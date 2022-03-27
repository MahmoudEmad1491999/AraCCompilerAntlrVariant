grammar AraC;

program: (
		globalVarDecl
		| funcDecl
		| opDecl
	)+;

globalVarDecl:
	dataType ID (ASSIGN_SYM expression)? FASLA_MANQUOTA;

funcDecl:
	FUNC_KEYWORD ID RP paramList LP COLON dataType RCB statement* LCB;

opDecl:
	OP_KEYWORD ID RP paramList LP RCB statement* LCB;

paramList: (dataType ID (FASLA dataType ID)*)?;

expression:
	expression RP argumentList LP									# FuncCallExpr
	| expression RSB expression LSB									# ArrSubScripExpr
	| (PLUS | MINUS) expression										# UnaryArithmeticExpr
	| (LOGICAL_NOT | BNOT_SYM) expression							# UnaryBLExpr
	| RP dataType LP expression									# CastingExpr
	| ADDRESS_OF_OPERATOR expression								# AddressExpr
	| VALUE_INSIDE_OPERATOR expression								# IndirectionExpr
	| SIZE_OF expression											# SizeExpr
	| expression DIVIDE expression									# DivExpr
	| expression MULTIPLY expression								# MultiplyExpr
	| expression MINUS expression									# SubtractExpr
	| expression PLUS expression									# AddExpr
	| expression (GTE_SYM | LTE_SYM | GT_SYM | LT_SYM) expression	# CompExpr
	| expression (EQUAL_SYM | NOTEQ_SYM) expression					# EualityExpr
	| expression (BAND_SYM) expression								# BandExpr
	| expression (BXOR_SYM) expression								# BxorExpr
	| expression (BOR_SYM) expression								# BorExpr
	| expression (LAND) expression									# LandExpr
	| expression (LOR) expression									# LorExpr
	| RP expression LP												# ParenthesisExpr
	| Literal														# LiteralExpr
	| ID															# IDExpr;

argumentList: (expression (FASLA expression)*)?;

statement:
	assignmentStat		        # assignment_Stat
	| returnStat			    # return_Stat
	| resultStat			    # result_Stat
	| ifStat				    # if_Stat
	| whileStat			        # while_Stat
	| varDecl			        # var_Decl
	| expression FASLA_MANQUOTA	# expression_Stat;

assignmentStat: ID ASSIGN_SYM expression FASLA_MANQUOTA;

ifStat: IF_KEYWORD RP expression LP RCB statement* LCB;

whileStat:
	WHILE_KEYWORD RP expression LP RCB statement* LCB;

returnStat: RET_KEYWORD FASLA_MANQUOTA;

resultStat: RES_KEYWORD expression FASLA_MANQUOTA;

varDecl:
	dataType ID (ASSIGN_SYM expression)? FASLA_MANQUOTA;

Literal:
	ARABIC_INT_LITERAL
	| ENGLISH_INT_LITERAL;

LP: '(';
RP: ')';
LSB: '[';
RSB: ']';
LCB: '{';
RCB: '}';

// memory address operators
ADDRESS_OF_OPERATOR: '&:';
VALUE_INSIDE_OPERATOR: '*:';
SIZE_OF: 'حجم:';

// punctuation symbols.
DOT: '.';
FASLA: '،';
FASLA_MANQUOTA: '؛';
// ARROW: '->';
COLON: ':';

// mathimatical symbols.
PLUS: '+';
MINUS: '-';
MULTIPLY: '×';
DIVIDE: '÷';
ARABIC_MODULS: '٪';
MODULUS: '%';

// logical operations
LAND: '&&';
LOR: '||';
LOGICAL_NOT: '!';

// Bitwise symbols.
SL_SYM: '<<';
SRA_SYM: '>>>';
SR_SYM: '>>';
BAND_SYM: '&';
BOR_SYM: '|';
BXOR_SYM: '^';
BNOT_SYM: '~';

// Relational symbols.
LTE_SYM: '<=';
GTE_SYM: '>=';
LT_SYM: '<';
GT_SYM: '>';
EQUAL_SYM: '==';
NOTEQ_SYM: '!=';

// operative symbols.
ASSIGN_SYM: ':=';

// keywords
FUNC_KEYWORD: 'دالة';
OP_KEYWORD: 'عملية';

RET_KEYWORD: 'رجوع';
RES_KEYWORD: 'الناتج';

IF_KEYWORD: 'إذا' | 'اذا';
WHILE_KEYWORD: 'طالما';

BREAK_KEYWORD: 'قطع';
CONTINUE_KEYWORRD: 'تخظى' | 'تخطي';

INT_DATA_TYPE: 'صحيح';
UINT_DATA_TYPE: 'طبيعي';

BYTE_DATA_TYPE: 'صحيح_١';
UBYTE_DATA_TYPE: 'طبيعي_١';

SHORT_DATA_TYPE: 'صحيح_٢';
USHORT_DATA_TYPE: 'طبيعي_٢';

LONG_DATA_TYPE: 'صحيح_٨';
ULONG_DATA_TYPE: 'طبيعي_٨';

// literal values.
// STRING_LITERAL:
// 	'"' (ESCAPED_CHARACTERS | ~('\u0022' | '\u0000'))* '"';

// fragment ESCAPED_CHARACTERS: ('//' | '/"' | '/0');

// CHARACTER_LITERAL:
	// '\'' (ESCAPED_CHARACTERS | ~('\u0027' | '\u0000')) '\'';

WHITE_SPACE: [\u0020\u0009\u000A\u000B\u000C\u000D] -> skip;

ARABIC_INT_LITERAL: [٠-٩]+;
ENGLISH_INT_LITERAL: [0-9]+;

// Identifier regular expression.
ID: [a-zA-Zء-ي] [a-zA-Zء-ي0-9٠-٩_]*;

dataType:
	INT_DATA_TYPE
	| UINT_DATA_TYPE
	| BYTE_DATA_TYPE
	| UBYTE_DATA_TYPE
	| SHORT_DATA_TYPE
	| USHORT_DATA_TYPE
	| LONG_DATA_TYPE
	| ULONG_DATA_TYPE;