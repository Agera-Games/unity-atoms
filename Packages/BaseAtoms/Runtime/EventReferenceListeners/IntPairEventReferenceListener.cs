using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `IntPair`. Inherits from `AtomEventReferenceListener&lt;IntPair, IntPairAction, IntPairEvent, IntPairEventReference, IntPairUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Event Reference Listeners/IntPair Event Reference Listener")]
    public sealed class IntPairEventReferenceListener : AtomEventReferenceListener<
        IntPair,
        IntPairAction,
        IntPairEvent,
        IntPairEventReference,
        IntPairUnityEvent>
    { }
}