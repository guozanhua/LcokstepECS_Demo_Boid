using Lockstep.UnsafeECS.Game;
using Unity.Entities;
using UnityEngine;

namespace Lockstep.Game.UnityView {
    [DisallowMultipleComponent] 
    public class UnityBoidTagProxy : ComponentDataProxy<UnityBoidTag> { }
}