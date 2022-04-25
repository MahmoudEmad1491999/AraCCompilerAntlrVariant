using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
namespace AntlrExamples.Environment
{
    public abstract class SymTab
    {
        private List<SymTabEntry> entries;
        public SymTabType sym_tab_type { get; }
        public SymTab parent { get; }

        private List<SymTab> sub_tables;

        public SymTab(SymTabType sym_tab_type, SymTab parent)
        {
            this.entries = new List<SymTabEntry>();
            this.sub_tables = new List<SymTab>();
            this.sym_tab_type = sym_tab_type;
            this.parent = parent;
        }
        public void addEntry(SymTabEntry entry)
        {
            if (entry != null)
            {
                if (!is_symbol_reserved(entry.sym_id)) entries.Add(entry);
                else throw new ArgumentException("المعرف محجوز");
            }
        }

        public void addSubTable(SymTab symTab)
        {
            if (symTab != null)
            {
                this.sub_tables.Add(symTab);
            }
        }
        public List<SymTabEntry> GetSymTabEntries()
        {
            var temp = new List<SymTabEntry>();
            temp.AddRange(entries);
            if (parent != null) temp.AddRange(parent.GetSymTabEntries());
            return temp;
        }
        public List<SymTab> GetSymTabs()
        {
            return this.sub_tables;
        }
        public SymTabEntry get_symbol_entry_by_id(string id){
            if(is_symbol_reserved(id)){
                var temp = this.entries.Find((SymTabEntry entry) => {
                    return entry.sym_id == id;
                });
                if(temp == null){
                    temp = parent.get_symbol_entry_by_id(id);
                }
                return temp;
            }else {
                throw new Exception("Undefined symbol");
            }
        }
        public bool is_symbol_reserved(string symbol)
        {
            for (int index = 0; index < entries.Count; index++)
            {
                if (symbol == entries[index].sym_id) return true;
            }
            if (parent != null)
            {
                return parent.is_symbol_reserved(symbol);
            }
            return false;
        }
        public static void print_symbol_table(SymTab symtab)
        {
            var entries = symtab.GetSymTabEntries();
            for (int index = 0; index < entries.Count; index++)
            {
                var entrystring = new StringBuilder();
                entrystring.Append(symtab.GetType().Name);
                entrystring.Append(": ");
                entrystring.Append(entries[index]);
                Console.WriteLine(entrystring.ToString());
            }
            var sub_tables = symtab.GetSymTabs();

            for (int index = 0; index < sub_tables.Count; index++)
            {
                print_symbol_table(sub_tables[index]);
            }
        }
    }
    public class ProgramSymTab : SymTab
    {
        public ProgramSymTab(SymTab parent) : base(SymTabType.FILE, parent)
        {
        }
    }
    public class FuncSymTab : SymTab
    {
        public string function_name;
        public FuncSymTab(SymTab parent, string function_name) : base(SymTabType.FUNCTION, parent)
        {
            this.function_name = function_name;
        }
    }
    public class OperSymTab : SymTab
    {
        public OperSymTab(SymTab parent) : base(SymTabType.OPERATION, parent)
        {
        }
    }
    public class IfStatSymTab : SymTab
    {
        public IfStatSymTab(SymTab parent) : base(SymTabType.IFSTAT, parent)
        {

        }
    }
    public class WhileStatSymTab : SymTab
    {
        public WhileStatSymTab(SymTab parent) : base(SymTabType.WHILESTAT, parent)
        {
        }
    }
    public enum SymTabType
    {
        FUNCTION,
        OPERATION,
        FILE,
        IFSTAT,
        WHILESTAT
    }

}