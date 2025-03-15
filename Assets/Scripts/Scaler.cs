using DG.Tweening;
using UnityEngine;

public class Scaler : Changer<Vector3>
{
    protected override void Animate()
    {
        transform.DOScale(EndValue, Duration).SetLoops(InfinityLoopValue, LoopType.Yoyo);
    }
}

