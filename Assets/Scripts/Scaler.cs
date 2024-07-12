using DG.Tweening;
using UnityEngine;

public class Scaler : BaseBehaviour
{
    [SerializeField] private Vector3 _maxScale;

    private void Start()
    {
        transform.DOScale(_maxScale, Duration).SetLoops(-1, LoopType.Yoyo);
    }
}
