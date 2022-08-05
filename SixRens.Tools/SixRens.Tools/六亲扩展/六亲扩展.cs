using SixRens.Tools.干支性质扩展;
using YiJingFramework.FiveElements;
using YiJingFramework.StemsAndBranches;

namespace SixRens.Tools.六亲扩展
{
    public static class 六亲扩展
    {
        public static 六亲 判断六亲(this FiveElement me, FiveElement other)
        {
            return (六亲)me.GetRelationship(other);
        }
        public static 六亲 判断六亲(this FiveElement me, EarthlyBranch other)
        {
            return me.判断六亲(other.五行());
        }
        public static 六亲 判断六亲(this FiveElement me, HeavenlyStem other)
        {
            return me.判断六亲(other.五行());
        }

        #region 我为天干
        public static 六亲 判断六亲(this HeavenlyStem me, FiveElement other)
        {
            return me.五行().判断六亲(other);
        }
        public static 六亲 判断六亲(this HeavenlyStem me, EarthlyBranch other)
        {
            return me.五行().判断六亲(other.五行());
        }
        public static 六亲 判断六亲(this HeavenlyStem me, HeavenlyStem other)
        {
            return me.五行().判断六亲(other.五行());
        }
        #endregion

        #region 我为地支
        public static 六亲 判断六亲(this EarthlyBranch me, FiveElement other)
        {
            return me.五行().判断六亲(other);
        }
        public static 六亲 判断六亲(this EarthlyBranch me, EarthlyBranch other)
        {
            return me.五行().判断六亲(other.五行());
        }
        public static 六亲 判断六亲(this EarthlyBranch me, HeavenlyStem other)
        {
            return me.五行().判断六亲(other.五行());
        }
        #endregion
    }
}
