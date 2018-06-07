using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.DAL
{
    public class DataContextFactory
    {
        private static SistemaDataContext dataContext;
        public static SistemaDataContext DataContext
        {
            get
            {
                if (dataContext == null)
                    dataContext = new SistemaDataContext();
                return dataContext;
            }
        }
    }
}
