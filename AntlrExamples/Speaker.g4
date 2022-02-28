
grammar Speaker;


line                : ('Hello' | 'hello') ID EOF;
ID                  :[a-zA-Z]+;
WHITESPACE          :[ \n\t\r]+ -> skip;