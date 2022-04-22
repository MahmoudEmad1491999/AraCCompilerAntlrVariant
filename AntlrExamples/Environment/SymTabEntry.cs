namespace AntlrExamples.Environment
{
    public abstract class SymTabEntry
    {
        public SymType sym_type;
        public string sym_id;
        public SymTabEntry(SymType sym_type, string sym_id)
        {
            this.sym_type = sym_type;
            this.sym_id = sym_id;
        }
    }

    public class GVarSymTabEntry : SymTabEntry
    {
        public string data_type;
        public GVarSymTabEntry(string sym_id, string data_type) : base(SymType.GLOBAL_VARIABLE, sym_id) { 
            this.data_type = data_type;
        }
    }
    public class FuncSymTabEntry : SymTabEntry
    {
        public FuncSymTabEntry(string sym_id, string return_type) : base(SymType.FUNCTION, sym_id) { }
    }
    public class OperSymTabEntry : SymTabEntry
    {
        public OperSymTabEntry(string sym_id) : base(SymType.OPERATION, sym_id) { }
    }
    public class ParamSymTabEntry : SymTabEntry
    {
        public string data_type;
        public ParamSymTabEntry(string sym_id, string data_type) : base(SymType.PARAMETER, sym_id) { 
            this.data_type = data_type;
        }
    }
    public class LVarSymTabEntry : SymTabEntry
    {
        public string data_type;
        public LVarSymTabEntry(string sym_id, string data_type) : base(SymType.LOCAL_VARIABLE, sym_id) { 
            this.data_type = data_type;
        }
    }
    public class FileSymTabEntry : SymTabEntry
    {
        public FileSymTabEntry(SymType sym_type, string sym_id) : base(SymType.FILE, sym_id)
        {
        }
    }
    public enum SymType
    {
        FUNCTION,
        OPERATION,
        GLOBAL_VARIABLE,
        PARAMETER,
        LOCAL_VARIABLE,
        FILE
    }
}