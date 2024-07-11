using DG.Tweening;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private Vector3 _target;
    [SerializeField] private float _duration;

    private void Start()
    {
        transform.DOMove(_target, _duration).SetLoops(-1, LoopType.Restart);
    }
}
