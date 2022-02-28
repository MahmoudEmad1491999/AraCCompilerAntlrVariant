grammar AraC;

program             : 'Hello' EOF;




IDENTIFIER          : [a-zA-Zا-ي] [a-zA-Zا-ي0-9٠-٩_]*;
ARABIC_INT_LITERAL  : [١-٩][٠-٩]*;
ENGLISH_INT_LITERAL : [1-9][0-9]*;
LEFT_BOW            : '(';
RIGHT_BOW           : ')';
LEFT_SQUARE         : '[';
RIGHT_SQUARE        : ']';
LEFT_CURLY          : '{';
RIGHT_CURLY         : '}';

PLUS                : '+';
MINUS               : '-';
MULTIPLY            : '×';
DIVIDE              : '÷';
ARABIC_MODULS       : '٪';


SHIFT_LEFT                  : '<<';
SHIFT_RIGHT_ARITHMETIC      : '>>>';
SHIFT_RIGHT                 : '>>';

LESS_THAN_EQUAL             : '<=';
GREATER_THAN_EQUAL          : '>=';

LEFT_ANGLE                  : '<';
RIGHT_ANGLE                 : '>';

EQUAL           : '==';
NOT_EQUAL       : '!=';

ASSIGN          : '=';

DOT             : '.';
FASLA           : '،';
FASLA_MANQUOTA  : '؛';


FUNCTION: 'دالة';
OPERATION: 'عملية';

RETURN_KEYWORD: 'رجوع';
RESULT_KEYWORD: 'الناتج';

IF_KEYWORD      : 'IF';
WHILE_KEYWORD   : 'WHILE';

INT_DATA_TYPE   : 'صحيح';
UINT_DATA_TYPE  : 'طبيعي';

BYTE_KEYWORD        : 'صحيح_١';
UBYTE_KEYWORD       : 'طبيعي_١';

SHORT_KEYWORD       : 'صحيح_٢';
USHORT_KEYWORD      : 'طبيعي_٢';

LONG_KEYWORD        : 'صحيح_٨';
ULONG_KEYWORD       : 'طبيعي_٨';
