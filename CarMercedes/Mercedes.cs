using System;
using CarContract;

namespace CarMercedes
{
    public class Mercedes : CarBase
    {
        public override string StartEngine(string name)
        {
            return String.Format("{0} starts the Mercedes.", name);
        }
    }
}
