using System;
using System.ComponentModel.Composition;

namespace CarContract
{
    [InheritedExport(typeof(ICarContract))]    
    [ExportMetadata("Name", "no name")]
    [ExportMetadata("Color", "no color")]
    public class CarBase : ICarContract
    {
        public virtual string StartEngine(string name)
        {
            return String.Format("{0} starts the BaseCar.", name);
        }
    }
}
