using DG.Tweening;
using UnityEngine;

public class Mover : Changer<Vector3>
{
    protected override void Animate()
    {
        transform.DOMove(EndValue, Duration).SetLoops(InfinityLoopValue, LoopType.Yoyo);
    }
}
