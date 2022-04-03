using System;
using System.IO;
using System.Collections.Generic;

namespace AntlrExamples.Misc {
    public class SymbolTable {
        public List<SymbolTableEntry> table;
        public SymbolTable(){
            this.table = new List<SymbolTableEntry>();
        }
        public void addSymbol(SymbolTableEntry symbolTableEntry) {
            table.Add(symbolTableEntry);
        }
        public bool hasSymbol(SymbolTableEntry symbolTableEntry){
            return table.Contains(symbolTableEntry);
        }
    }
}