using System.Collections.Generic;

namespace AntlrExamples.Misc {
    public class SymbolTable {
        public SymbolTable enclosing_table;
        public List<SymbolTableEntry> table;

        public SymbolTable(SymbolTable _enclosing_table){
            this.enclosing_table = _enclosing_table;
        }
        
        public void push_entry(SymbolTableEntry new_entry){
            this.table.Add(new_entry);
        }

        public bool has_entry(SymbolTableEntry suspect_entry){
            return table.Contains(suspect_entry);
        }
    }
}