using YiJingFramework.FiveElements;
using YiJingFramework.StemsAndBranches;

namespace SixRens.Tools
{
    public static class 五行十二长生扩展
    {
        private static readonly IReadOnlyDictionary<FiveElement, EarthlyBranch> 长生支表 =
            new Dictionary<FiveElement, EarthlyBranch>()
            {
                { FiveElement.Wood, new EarthlyBranch(12) },
                { FiveElement.Fire, new EarthlyBranch(3) },
                { FiveElement.Metal, new EarthlyBranch(6) },
                { FiveElement.Water, new EarthlyBranch(9) },
                { FiveElement.Earth, new EarthlyBranch(9) }
            };

        public static 十二长生 以支取长生(
            this FiveElement 五行, EarthlyBranch 支)
        {
            var difference = 支.Index - 长生支表[五行].Index;
            return (十二长生)((difference + 12) % 12);
        }

        public static EarthlyBranch 以长生取支(
            this FiveElement 五行, 十二长生 长生)
        {
            return 长生支表[五行].Next((int)长生);
        }
    }
}
