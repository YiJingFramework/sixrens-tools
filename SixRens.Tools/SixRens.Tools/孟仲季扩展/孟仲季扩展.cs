using YiJingFramework.StemsAndBranches;

namespace SixRens.Tools.孟仲季扩展
{
    public static class 地支孟仲季扩展
    {
        public static 孟仲季 获取孟仲季(this EarthlyBranch 支)
        {
            return (孟仲季)(支.Index % 12 % 3);
        }
    }
}
