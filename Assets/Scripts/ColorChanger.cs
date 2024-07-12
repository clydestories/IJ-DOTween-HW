using DG.Tweening;
using UnityEngine;

[RequireComponent (typeof(Renderer))]
public class ColorChanger : BaseBehaviour
{
    [SerializeField] private Color _color;

    private Renderer _renderer;

    private void Awake()
    {
        _renderer = GetComponent<Renderer>();
    }

    private void Start()
    {
        _renderer.material.DOColor(_color, Duration).SetLoops(-1, LoopType.Yoyo);
    }
}
