using DG.Tweening;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] private Vector3 _endPosition;

    private void Start()
    {
        transform.DOMove(_endPosition, _duration).SetLoops(-1, LoopType.Yoyo);
    }
}
