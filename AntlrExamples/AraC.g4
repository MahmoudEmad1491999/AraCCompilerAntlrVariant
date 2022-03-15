grammar AraC;

program: (
		global_var_declaratoin
		| function_declaration
		| operatoin_declaration
	)*;

global_var_declaratoin:
	data_type IDENTIFIER (ASSIGN expression)? FASLA_MANQUOTA;

function_declaration:
	FUNCTION IDENTIFIER RIGHT_PARENTHESIS param_list LEFT_PARENTHESIS data_type RIGHT_CURLY_BRACKET
		statement* LEFT_CURLY_BRACKET;

param_list: (data_type IDENTIFIER ('،' data_type IDENTIFIER)*)
	|;

operatoin_declaration:
	OPERATION IDENTIFIER RIGHT_PARENTHESIS LEFT_PARENTHESIS RIGHT_CURLY_BRACKET statement*
		LEFT_CURLY_BRACKET;

expression:
	expression RIGHT_PARENTHESIS argument_list LEFT_PARENTHESIS					# funciton_calling_expression
	| expression RIGHT_SQUARE_BRACKET expression LEFT_SQUARE_BRACKET			# array_subscription_expression
	| expression (DOT | ARROW) expression										# dot_arrow_expression
	| (PLUS | MINUS) expression													# unary_plus_or_minus_expression
	| (LOGICAL_NOT | BITWISE_NOT) expression									# unary_negation_logical_and_bitwise
	| RIGHT_PARENTHESIS (IDENTIFIER | data_type) LEFT_PARENTHESIS expression	# casting_expression
	| ADDRESS_OF_OPERATOR expression											# address_of_expression
	| VALUE_INSIDE_OPERATOR expression											# value_inside_address_expression
	| SIZE_OF expression														# size_of_expression
	| expression (MULTIPLY | DIVIDE) expression									# multiplicative_expression
	| expression (PLUS | MINUS) expression										# additive_expression
	| expression (SHIFT_RIGHT | SHIFT_LEFT) expression							# bitwise_shift_expression
	| expression (
		GREATER_THAN_EQUAL
		| LESS_THAN_EQUAL
		| GREATER_THAN
		| LESS_THAN
	) expression									# comparative_expression
	| expression (EQUAL | NOT_EQUAL) expression		# equality_testing_expression
	| expression (BITWISE_AND) expression			# bitwise_and_expression
	| expression (BITWISE_XOR) expression			# bitwise_xor_expression
	| expression (BITWISE_OR) expression			# bitwise_or_expression
	| expression (LOGICAL_AND) expression			# logical_and_expressoin
	| expression (LOGICAL_OR) expression			# logical_or_expression
	| RIGHT_PARENTHESIS expression LEFT_PARENTHESIS	# parenthesis_expression
	| Literal										# literal_expression
	| IDENTIFIER									# identifier_expression;

argument_list: expression (FASLA expression)*;

statement:
	assignment_statement		# assignment_statement_typeof_statement
	| return_statement			# return_statement_typeof_statement
	| result_statement			# result_statement_typeof_statement
	| if_statement				# if_statement_typeof_statement
	| while_statement			# while_statement_typeof_statement
	| var_declaration			# var_declaration_typeof_statement
	| expression FASLA_MANQUOTA	# expression_statement_typeof_statement;

assignment_statement:
	left_hand_side ASSIGN expression FASLA_MANQUOTA;

left_hand_side: IDENTIFIER;

if_statement:
	IF_KEYWORD RIGHT_PARENTHESIS expression LEFT_PARENTHESIS RIGHT_CURLY_BRACKET statement*
		LEFT_CURLY_BRACKET;

while_statement:
	WHILE_KEYWORD RIGHT_PARENTHESIS expression LEFT_PARENTHESIS RIGHT_CURLY_BRACKET statement*
		LEFT_CURLY_BRACKET;

return_statement: RETURN_KEYWORD FASLA_MANQUOTA;

result_statement: RESULT_KEYWORD expression FASLA_MANQUOTA;

var_declaration:
	data_type IDENTIFIER (ASSIGN expression)? FASLA_MANQUOTA;

Literal:
	STRING_LITERAL
	| CHARACTER_LITERAL
	| ARABIC_INT_LITERAL
	| ENGLISH_INT_LITERAL;

LEFT_PARENTHESIS: '(';
RIGHT_PARENTHESIS: ')';
LEFT_SQUARE_BRACKET: '[';
RIGHT_SQUARE_BRACKET: ']';
LEFT_CURLY_BRACKET: '{';
RIGHT_CURLY_BRACKET: '}';

// memory address operators
ADDRESS_OF_OPERATOR: 'عنوان:';
VALUE_INSIDE_OPERATOR: 'قيمة:';
SIZE_OF: 'حجم:';

// punctuation symbols.
DOT: '.';
FASLA: '،';
FASLA_MANQUOTA: '؛';
ARROW: '->';
colon: ':';

// mathimatical symbols.
PLUS: '+';
MINUS: '-';
MULTIPLY: '×';
DIVIDE: '÷';
ARABIC_MODULS: '٪';
MODULUS: '%';

// logical operations
LOGICAL_AND: '&&';
LOGICAL_OR: '||';
LOGICAL_NOT: '!';

// Bitwise symbols.
SHIFT_LEFT: '<<';
SHIFT_RIGHT_ARITHMETIC: '>>>';
SHIFT_RIGHT: '>>';
BITWISE_AND: '&';
BITWISE_OR: '|';
BITWISE_XOR: '^';
BITWISE_NOT: '~';

// Relational symbols.
LESS_THAN_EQUAL: '<=';
GREATER_THAN_EQUAL: '>=';
LESS_THAN: '<';
GREATER_THAN: '>';
EQUAL: '==';
NOT_EQUAL: '!=';

// operative symbols.
ASSIGN: ':=';

// keywords
FUNCTION: 'دالة';
OPERATION: 'عملية';

RETURN_KEYWORD: 'رجوع';
RESULT_KEYWORD: 'الناتج';

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
STRING_LITERAL:
	'"' (ESCAPED_CHARACTERS | ~('\u0022' | '\u0000'))* '"';

fragment ESCAPED_CHARACTERS: ('//' | '/"' | '/0');

CHARACTER_LITERAL:
	'\'' (ESCAPED_CHARACTERS | ~('\u0027' | '\u0000')) '\'';

WHITE_SPACE: [\u0020\u0009\u000A\u000B\u000C\u000D] -> skip;

ARABIC_INT_LITERAL: [٠-٩]+;
ENGLISH_INT_LITERAL: [0-9]+;

// Identifier regular expression.
IDENTIFIER: [a-zA-Zء-ي] [a-zA-Zء-ي0-9٠-٩_]*;

data_type:
	INT_DATA_TYPE
	| UINT_DATA_TYPE
	| BYTE_DATA_TYPE
	| UBYTE_DATA_TYPE
	| SHORT_DATA_TYPE
	| USHORT_DATA_TYPE
	| LONG_DATA_TYPE
	| ULONG_DATA_TYPE;