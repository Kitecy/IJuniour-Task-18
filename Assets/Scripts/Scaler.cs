using DG.Tweening;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] private Vector3 _endScale;

    private void Start()
    {
        transform.DOScale(_endScale, _duration).SetLoops(-1, LoopType.Yoyo);
    }
}

