using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedConditionRefactorSample02
{
    public interface ICheckData
    {
        bool GetResult();
    }

    public class CheckData<T> : ICheckData where T : IComparable<T>
    {
        private T _source;
        private T _target;

        public CheckData(T source, T target)
        {
            _source = source;
            _target = target;
        }
        public bool GetResult()
        {
            return (_source.CompareTo(_target) == 0);
        }
    }
}
