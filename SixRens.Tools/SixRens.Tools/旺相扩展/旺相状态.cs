using YiJingFramework.FiveElements;

namespace SixRens.Tools.旺相扩展
{
    public enum 旺相状态
    {
        旺 = FiveElementsRelationship.SameAsMe,
        相 = FiveElementsRelationship.GeneratingMe,
        休 = FiveElementsRelationship.GeneratedByMe,
        囚 = FiveElementsRelationship.OvercameByMe,
        死 = FiveElementsRelationship.OvercomingMe
    }
}
