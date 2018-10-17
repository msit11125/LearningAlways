using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleLibrary
{
    public interface IStandardWeightFactory
    {
        StandardWightStrategy GetStrategy(Human human);
    }


    public class ManStandardWeightFactory : IStandardWeightFactory
    {
        public StandardWightStrategy GetStrategy(Human human)
        {
            return new ManStandardStrategy(human);
        }
    }

    public class WomanStandardWeightFactory : IStandardWeightFactory
    {
        public StandardWightStrategy GetStrategy(Human human)
        {
            return new WomanStandardStrategy(human);
        }
    }
}
