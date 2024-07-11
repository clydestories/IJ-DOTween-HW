using DG.Tweening;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private Vector3 _maxScale;
    [SerializeField] private float _duration;

    private void Start()
    {
        transform.DOScale(_maxScale, _duration).SetLoops(-1, LoopType.Yoyo);
    }
}
