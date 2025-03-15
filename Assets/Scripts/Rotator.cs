using DG.Tweening;
using UnityEngine;

public class Rotator : Changer<Vector3>
{
    protected override void Animate()
    {
        transform.DORotate(EndValue, Duration).SetLoops(InfinityLoopValue);
    }
}
