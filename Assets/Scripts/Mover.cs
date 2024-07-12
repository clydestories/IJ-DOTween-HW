using DG.Tweening;
using UnityEngine;

public class Mover : BaseBehaviour
{
    [SerializeField] private Vector3 _target;

    private void Start()
    {
        transform.DOMove(_target, Duration).SetLoops(-1, LoopType.Restart);
    }
}
