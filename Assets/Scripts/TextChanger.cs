using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] private int _from;
    [SerializeField] private int _to;

    private Text _text;

    private void Awake()
    {
        _text = GetComponent<Text>();
    }

    private void Start()
    {
        _text.DOCounter(_from, _to, _duration).SetLoops(-1);
    }
}
