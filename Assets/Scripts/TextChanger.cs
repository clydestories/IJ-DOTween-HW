using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private string _content;
    [SerializeField] private float _duration;
    [SerializeField] private Text _text;

    private void Start()
    {
        _text.DOText(_content, _duration, true, ScrambleMode.Numerals);
    }
}
