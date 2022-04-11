using System;
using System.IO;
using System.Collections.Generic;

namespace AntlrExamples.Environment {
    public class SymbolTable {
        public List<SymbolTableEntry> table;
        public List<SymbolTable> accessable_tables;
        public SymbolTable(){
            this.table = new List<SymbolTableEntry>();
            this.accessable_tables = new List<SymbolTable>();
        }
        public void addSymbol(SymbolTableEntry symbolTableEntry) {
            table.Add(symbolTableEntry);
        }
        public bool hasSymbol(SymbolTableEntry symbolTableEntry){
            return table.Contains(symbolTableEntry);
        }
    }
}