using System.Collections;
using YiJingFramework.FiveElements;
using YiJingFramework.StemsAndBranches;

namespace SixRens.Tools
{
    public static class 地支四时扩展
    {
        public static 四时 获取四时(this EarthlyBranch 支)
        {
            return (四时)(支.Index % 12 / 4);
        }

        public static I四时局 取所在四时局(this EarthlyBranch 支)
        {
            return new 四时局(支);
        }

        public interface I四时局 : IEnumerable<EarthlyBranch>
        {
            EarthlyBranch 孟支 { get; }
            四时 四时 => this.孟支.获取四时();
            public EarthlyBranch 仲支 => this.孟支.Next();
            public EarthlyBranch 季支 => this.孟支.Next(2);
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
