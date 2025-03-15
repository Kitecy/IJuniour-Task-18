using DG.Tweening;
using UnityEngine.UI;

public class TextChanger : Changer<string>
{
    private Text _text;

    private void Awake()
    {
        _text = GetComponent<Text>();
    }

    protected override void Animate()
    {
        Sequence sequence = DOTween.Sequence();
        sequence.Append(_text.DOText(EndValue, Duration));
        sequence.Append(_text.DOText(string.Empty, Duration));
        sequence.Append(_text.DOText(EndValue + EndValue, Duration));
        sequence.Append(_text.DOText(EndValue, Duration, scrambleMode: ScrambleMode.Numerals));
        sequence.SetLoops(InfinityLoopValue, LoopType.Yoyo);
    }
}
