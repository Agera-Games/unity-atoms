#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Variable property drawer of type `bool`. Inherits from `AtomDrawer&lt;BoolVariable&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(BoolVariable))]
    public class BoolVariableDrawer : VariableDrawer<BoolVariable> { }
}
#endif