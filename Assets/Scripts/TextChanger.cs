using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : BaseBehaviour
{
    [SerializeField] private string _content1;
    [SerializeField] private string _content2;
    [SerializeField] private string _content3;
    [SerializeField] private Text _text;
    [SerializeField] private float _delay;

    private void Start()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(_text.DOText(_content1, Duration, true, ScrambleMode.Numerals).SetDelay(_delay));
        sequence.Append(_text.DOText(_content2, Duration, false, ScrambleMode.Lowercase).SetDelay(_delay));
        sequence.Append(_text.DOText(_content3, Duration, true, ScrambleMode.Uppercase).SetDelay(_delay));
        sequence.SetLoops(-1, LoopType.Incremental);
    }
}
