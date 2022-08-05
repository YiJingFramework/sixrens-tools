using SixRens.Tools.四时旺相扩展;
using SixRens.Tools.干支性质扩展;
using YiJingFramework.FiveElements;
using YiJingFramework.StemsAndBranches;

namespace SixRens.Tools.旺相扩展
{
    public static class 旺相扩展
    {
        public static 旺相状态 取旺相状态(this FiveElement 五行, FiveElement 所处)
        {
            return (旺相状态)五行.GetRelationship(所处);
        }

        public static 旺相状态 取旺相状态(this HeavenlyStem 天干, FiveElement 所处)
        {
            return 取旺相状态(天干.五行(), 所处);
        }

        public static 旺相状态 取旺相状态(this EarthlyBranch 地支, FiveElement 所处)
        {
            return 取旺相状态(地支.五行(), 所处);
        }

        #region 处四时
        public static 旺相状态 取旺相状态(this FiveElement 五行, 四时 所处)
        {
            return 取旺相状态(五行, 所处.五行());
        }

        public static 旺相状态 取旺相状态(this HeavenlyStem 天干, 四时 所处)
        {
            return 取旺相状态(天干.五行(), 所处.五行());
        }

        public static 旺相状态 取旺相状态(this EarthlyBranch 地支, 四时 所处)
        {
            return 取旺相状态(地支.五行(), 所处.五行());
        }
        #endregion

        #region 处地支
        public static 旺相状态 取旺相状态(this FiveElement 五行, EarthlyBranch 所处)
        {
            return 取旺相状态(五行, 所处.五行());
        }

        public static 旺相状态 取旺相状态(this HeavenlyStem 天干, EarthlyBranch 所处)
        {
            return 取旺相状态(天干.五行(), 所处.五行());
        }

        public static 旺相状态 取旺相状态(this EarthlyBranch 地支, EarthlyBranch 所处)
        {
            return 取旺相状态(地支.五行(), 所处.五行());
        }
        #endregion
    }
}
