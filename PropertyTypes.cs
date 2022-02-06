using System.Dynamic;

namespace NewCSharpConcepts
{
    //Flavours of properties

    public class PropertyTypes
    {
      
        //Full Property
        private string? _name;
        public string? Name
        {
            get { return _name; } 
            set { _name = value;}
        }

        //Automatic
        public string? AutoName { get; set; }
        
        //Read Only
        public string? ReadOnlyName { get; }

        //Read Only with initialision
        public string? ReadsOnlyWithInitName { get; } = "Koos Du Plessis";


    }
}