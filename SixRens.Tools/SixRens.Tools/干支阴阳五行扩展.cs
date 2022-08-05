using YiJingFramework.Core;
using YiJingFramework.FiveElements;
using YiJingFramework.StemsAndBranches;

namespace SixRens.Tools
{
    public static class 干支阴阳五行扩展
    {
        public static FiveElement 五行(this HeavenlyStem stem)
        {
            return (FiveElement)((stem.Index - 1) / 2);
        }

        public static FiveElement 五行(this EarthlyBranch branch)
        {
            if (branch.Index % 3 == 2)
                return FiveElement.Earth;

            return (branch.Index / 3) switch {
                0 or 4 => FiveElement.Water,
                1 => FiveElement.Wood,
                2 => FiveElement.Fire,
                _ => FiveElement.Metal // 3
            };
        }

        public static YinYang 阴阳(this HeavenlyStem stem)
        {
            return new YinYang(stem.Index % 2 == 1);
        }

        public static YinYang 阴阳(this EarthlyBranch branch)
        {
            return new YinYang(branch.Index % 2 == 1);
        }
    }
}
