using DG.Tweening;
using UnityEngine;

public class Spinner : BaseBehaviour
{
    [SerializeField] private Vector3 _endRotation;

    private void Start()
    {
        transform.DORotate(_endRotation, Duration).SetLoops(-1, LoopType.Incremental).SetEase(Ease.Linear);
    }
}
