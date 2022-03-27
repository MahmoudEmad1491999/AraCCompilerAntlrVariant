namespace AntlrExamples.Misc{    
    public class SymbolTableEntry {
        string id;
        SymbolType symbol_type;
        SymbolTable parent_table;
        public SymbolTableEntry(string _id, SymbolType _symbol_type, SymbolTable _parent_table) {
            this.id = _id;
            this.symbol_type = _symbol_type;
            this.parent_table = _parent_table;
        }
    }

}