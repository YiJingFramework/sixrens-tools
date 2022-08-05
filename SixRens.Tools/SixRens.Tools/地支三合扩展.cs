using System.Collections;
using System.Diagnostics;
using YiJingFramework.FiveElements;
using YiJingFramework.StemsAndBranches;

namespace SixRens.Tools
{
    public static class 地支三合扩展
    {
        public interface I三合局 : IEnumerable<EarthlyBranch>
        {
            EarthlyBranch 长生支 { get; }
            public EarthlyBranch 帝旺支 => this.长生支.Next(4);
            public EarthlyBranch 墓支 => this.长生支.Next(8);
            public FiveElement 合化五行 => this.帝旺支.五行();
            private IEnumerable<EarthlyBranch> AsEnumerable()
            {
                yield return this.长生支;
                yield return this.帝旺支;
                yield return this.墓支;
            }

            IEnumerator<EarthlyBranch> IEnumerable<EarthlyBranch>.GetEnumerator()
            {
                return this.AsEnumerable().GetEnumerator();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return this.AsEnumerable().GetEnumerator();
            }
        }
        private class 三合局 : I三合局
        {
            public EarthlyBranch 长生支 { get; }

            internal 三合局(EarthlyBranch 其中一支)
            {
                if (其中一支.获取孟仲季() is 孟仲季.孟)
                {
                    this.长生支 = 其中一支;
                    return;
                }

                其中一支 = 其中一支.Next(4);
                if (其中一支.获取孟仲季() is 孟仲季.孟)
                {
                    this.长生支 = 其中一支;
                    return;
                }

                其中一支 = 其中一支.Next(4);
                Debug.Assert(其中一支.获取孟仲季() is 孟仲季.孟);
                this.长生支 = 其中一支;
                return;
            }
        }
        public static I三合局 取所在三合局(this EarthlyBranch 支)
        {
            return new 三合局(支);
        }
        public static EarthlyBranch 取所在三合局后一支(this EarthlyBranch 支)
        {
            return 支.Next(-4);
        }
        public static EarthlyBranch 取所在三合局前一支(this EarthlyBranch 支)
        {
            return 支.Next(4);
        }
    }
}
