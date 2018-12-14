using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class SingleObject
    {
        public static SingleObject instance = new SingleObject();

        private SingleObject()
        { }

        public static SingleObject GetSingleObject()
        {
            return instance;
        }

        public string ShowMessage()
        {
            return "this is SingleObject";
        }
    }
}
