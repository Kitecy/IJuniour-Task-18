using UnityEngine;

public abstract class Changer<T> : MonoBehaviour
{
    protected const int InfinityLoopValue = -1;

    [SerializeField] protected float Duration;
    [SerializeField] protected T EndValue;

    private void Start()
    {
        Animate();
    }

    protected abstract void Animate();
}
