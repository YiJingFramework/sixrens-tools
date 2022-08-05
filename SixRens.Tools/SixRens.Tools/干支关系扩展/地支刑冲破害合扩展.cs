using YiJingFramework.StemsAndBranches;

namespace SixRens.Tools.干支关系扩展
{
    public static class 地支刑冲破害合扩展
    {
        public static EarthlyBranch 取六合(this EarthlyBranch branch)
        {
            var index = 1 - (branch.Index - 2);
            return new EarthlyBranch(index);
        }
        public static EarthlyBranch 取冲(this EarthlyBranch branch)
        {
            return branch.Next(6);
        }
        public static EarthlyBranch 取害(this EarthlyBranch branch)
        {
            var index = 10 - (branch.Index - 11);
            return new EarthlyBranch(index);
        }
        public static EarthlyBranch 取被所刑(this EarthlyBranch branch)
        {
            var index = branch.Index switch {
                4 => 1,
                11 => 2,
                6 => 3,
                1 => 4,
                5 => 5,
                9 => 6,
                7 => 7,
                2 => 8,
                3 => 9,
                10 => 10,
                8 => 11,
                _ => 12 // 12
            };
            return new EarthlyBranch(index);
        }
        public static EarthlyBranch 取所刑(this EarthlyBranch branch)
        {
            var index = branch.Index switch {
                1 => 4,
                2 => 11,
                3 => 6,
                4 => 1,
                5 => 5,
                6 => 9,
                7 => 7,
                8 => 2,
                9 => 3,
                10 => 10,
                11 => 8,
                _ => 12 // 12
            };
            return new EarthlyBranch(index);
        }
        public static EarthlyBranch 取破(this EarthlyBranch branch)
        {
            var sign = 1 - branch.Index % 2 * 2;
            // 奇负，偶正
            return branch.Next(3 * sign);
        }
    }
}
