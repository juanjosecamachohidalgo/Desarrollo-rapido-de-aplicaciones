using System;

namespace MVVMBasicoWpfApp.Models
{
    public class Model
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; private set; }

        public Model()
        {
            Created = DateTime.Now;
        }
        
        public override string ToString()
        {
            return String.Format("Description: {0} Value: {1} Created: {2}", Name, Code, Created);
        }
    }
}
