using SixRens.Tools.孟仲季扩展;
using SixRens.Tools.干支性质扩展;
using System.Collections;
using YiJingFramework.FiveElements;
using YiJingFramework.StemsAndBranches;

namespace SixRens.Tools.四时旺相扩展
{
    public static class 四时扩展
    {
        public static FiveElement 五行(this 四时 四时)
        {
            var 数 = (int)四时 + 1;
            数 += 数 / 4;
            return (FiveElement)(数 + 3);
        }

        public static 四时 获取四时(this EarthlyBranch 支)
        {
            return (四时)(支.Index % 12 / 4);
        }
        public static 四时? 获取四时(this FiveElement 五行)
        {
            return (int)五行 switch {
                0 => 四时.春,
                1 => 四时.夏,
                3 => 四时.秋,
                4 => 四时.冬,
                _ => null
            };
        }

        public static I四时局 获取四时局(this 四时 四时)
        {
            return new 四时局(new((int)四时 * 4));
        }

        public static I四时局 取所在四时局(this EarthlyBranch 支)
        {
            return new 四时局(支);
        }

        public interface I四时局 : IEnumerable<EarthlyBranch>
        {
            EarthlyBranch 孟支 { get; }
            public EarthlyBranch 仲支 => this.孟支.Next();
            public EarthlyBranch 季支 => this.孟支.Next(2);
            public 四时 四时 => this.孟支.获取四时();
            public FiveElement 五行 => this.孟支.五行();
            private IEnumerable<EarthlyBranch> AsEnumerable()
            {
                yield return this.孟支;
                yield return this.仲支;
                yield return this.季支;
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

        private class 四时局 : I四时局
        {
            public EarthlyBranch 孟支 { get; }

            internal 四时局(EarthlyBranch 其中一支)
            {
                this.孟支 = 其中一支.获取孟仲季() switch {
                    孟仲季.孟 => 其中一支,
                    孟仲季.仲 => 其中一支.Next(-1),
                    _ => 其中一支.Next(-2),
                };
            }
        }
    }
}
