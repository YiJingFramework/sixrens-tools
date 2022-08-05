using SixRens.Tools.干支性质扩展;
using YiJingFramework.StemsAndBranches;

namespace SixRens.Tools.十二长生扩展
{
    public static class 天干十二长生扩展
    {
        private static readonly IReadOnlyDictionary<int, int> 长生支表 =
            new Dictionary<int, int>()
            {
                { 1, 12 },
                { 2, 7 },
                { 3, 3 },
                { 4, 10 },
                { 5, 7 },
                { 6, 10 },
                { 7, 6 },
                { 8, 1 },
                { 9, 9 },
                { 10, 4 },
            };

        public static 十二长生 天干以支取长生(
            this HeavenlyStem 干, EarthlyBranch 支)
        {
            var difference = 长生支表[干.Index] - 支.Index;
            if (干.阴阳().IsYang)
                difference = -difference;
            return (十二长生)((difference + 12) % 12);
        }

        public static EarthlyBranch 天干以长生取支(
            this HeavenlyStem 干, 十二长生 长生)
        {
            var 差异 = (int)长生;
            if (干.阴阳().IsYang)
                差异 = -差异;
            return new(长生支表[干.Index] - 差异);
        }
    }
}
