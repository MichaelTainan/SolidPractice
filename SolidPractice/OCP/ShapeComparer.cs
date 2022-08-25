using System;
using System.Collections;

namespace SolidPractice.OCP;
/// <summary>
/// This compare program is used to compare objects' type in hashtable value.
/// When arraylist object has to use sort(), it need.
/// And in the future , if has need add new shapes, just modify this class, other shapes class doesn't need to modify,
/// This is match the OCP rule.
/// </summary>
public class ShapeComparer : IComparer
{
    private static Hashtable priorities = new Hashtable();
    static ShapeComparer()
    {
        // use typeof to check object class type.
        priorities.Add(typeof(Circle), 1);
        priorities.Add(typeof(Square), 2);
    }

    private int PriorityFor(Type type)
    {
        if (priorities.Contains(type))
            return (int)priorities[type];
        else
            return 0;
    }

    public int Compare(object? o1, object? o2)
    {
        int priority1 = PriorityFor(o1.GetType());
        int priority2 = PriorityFor(o2.GetType());
        return priority1.CompareTo(priority2);
    }
}

