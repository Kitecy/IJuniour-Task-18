using DG.Tweening;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class ColorChanger : Changer<Color>
{
    private MeshRenderer _meshRenderer;

    private void Awake()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
    }

    protected override void Animate()
    {
        _meshRenderer.material.DOColor(EndValue, Duration).SetLoops(InfinityLoopValue, LoopType.Yoyo);
    }
}
