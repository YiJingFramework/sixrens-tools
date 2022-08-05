using YiJingFramework.StemsAndBranches;

namespace SixRens.Tools
{
    public static class 天干寄宫扩展
    {
        public static EarthlyBranch 寄宫(this HeavenlyStem 干)
        {
            return new EarthlyBranch(
                干.Index switch {
                    1 => 3, // 甲课寅合
                    2 => 5, // 乙课辰，
                    3 or 5 => 6, // 丙戊课巳不须论，
                    4 or 6 => 8, // 丁已课未
                    7 => 9, // 庚申上，
                    8 => 11, // 辛戌
                    9 => 12, // 壬亥是其真，
                    _ => 2, // 癸课原来丑宫坐，
                    // 分明不用四正神。
                });
        }
    }
}
