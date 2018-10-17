using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleLibrary
{
    //男性： （身高cm－80）×70﹪＝標準體重
    //女性： （身高cm－70）×60﹪＝標準體重

    /// <summary>
    /// 計算標準體重的抽象類別
    /// </summary>
    public abstract class StandardWightStrategy
    {
        // 由建構子注入 Human
        protected Human _human;

        public Double StandardWeight
        { get; private set; }

        //強迫實做
        protected abstract Double Minuend
        { get; }

        protected abstract Double SacleRate
        { get; }

        protected void GetStandardWeight()
        {
            StandardWeight = (_human.Height * 100 - Minuend) * SacleRate;
        }

    }

    internal sealed class ManStandardStrategy : StandardWightStrategy
    {

        protected override double Minuend
        {
            get { return 80; }
        }

        protected override double SacleRate
        {
            get { return 0.7; }
        }

        public ManStandardStrategy(Human human)
        {
            _human = human;
            GetStandardWeight();
        }
    }

    internal sealed class WomanStandardStrategy : StandardWightStrategy
    {

        protected override double Minuend
        {
            get { return 70; }
        }

        protected override double SacleRate
        {
            get { return 0.6; }
        }

        public WomanStandardStrategy(Human human)
        {
            _human = human;
            GetStandardWeight();
        }
    }
}
