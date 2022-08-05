using YiJingFramework.FiveElements;

namespace SixRens.Tools.六亲扩展
{
    public enum 六亲
    {
        兄弟 = FiveElementsRelationship.SameAsMe,
        父母 = FiveElementsRelationship.GeneratingMe,
        官鬼 = FiveElementsRelationship.OvercomingMe,
        妻财 = FiveElementsRelationship.OvercameByMe,
        子孙 = FiveElementsRelationship.GeneratedByMe
    }
}
