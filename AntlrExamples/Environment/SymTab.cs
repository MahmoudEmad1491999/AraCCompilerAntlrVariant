using System;
using System.Collections.Generic;

namespace AntlrExamples.Environment
{
    public abstract class SymTab
    {
        public List<SymTabEntry> entries;
        public SymTabType sym_tab_type;
        public SymTab parent;

        public List<SymTab> sub_tables;

        public SymTab(List<SymTabEntry> entries, SymTabType sym_tab_type, SymTab parent, List<SymTab> sub_tables)
        {
            this.entries = entries;
            this.sym_tab_type = sym_tab_type;
            this.parent = parent;
            this.sub_tables = sub_tables;
        }
        public void addEntry(SymTabEntry entry)
        {
            if (entry != null)
            {
                for (int index = 0; index < entries.Count; index++)
                {
                    if (entries[index].sym_id == entry.sym_id)
                    {
                        throw new Exception("The Identifier: " + entry.sym_id + " is used as " + entries[index]);
                    }
                }
                entries.Add(entry)  ;
            }
        }
        public void addSubTable(SymTab symTab)
        {
            if (symTab != null)
            {
                this.sub_tables.Add(symTab);
            }
        }
    }
    public class FileSymTab : SymTab
    {
        public FileSymTab(List<SymTabEntry> entries, SymTab parent, List<SymTab> sub_tables) : base(entries, SymTabType.FILE, parent, sub_tables)
        {
        }
    }
    public class FuncSymTab : SymTab
    {
        public FuncSymTab(List<SymTabEntry> entries, SymTab parent, List<SymTab> sub_tables) : base(entries, SymTabType.FUNCTION, parent, sub_tables)
        {
        }
    }
    public class OperSymTab : SymTab
    {
        public OperSymTab(List<SymTabEntry> entries, SymTab parent, List<SymTab> sub_tables) : base(entries, SymTabType.OPERATION, parent, sub_tables)
        {
        }
    }
    public class IfStatSymTab : SymTab
    {
        public IfStatSymTab(List<SymTabEntry> entries, SymTab parent, List<SymTab> sub_tables) : base(entries, SymTabType.IFSTAT, parent, sub_tables)
        {

        }
    }
    public class WhileStatSymTab : SymTab
    {
        public WhileStatSymTab(List<SymTabEntry> entries, SymTab parent, List<SymTab> sub_tables) : base(entries, SymTabType.WHILESTAT, parent, sub_tables)
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