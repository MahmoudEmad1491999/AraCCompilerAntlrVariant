namespace AntlrExamples.Misc {
    public class SymbolTableEntry {
        public string literal;
        public SymbolType symboltype;
        public string return_type;
        public SymbolTableEntry(string literal, SymbolType symboltype, string return_type){
            this.literal = literal;
            this.symboltype = symboltype;
            this.return_type = return_type;
        }
    }
}