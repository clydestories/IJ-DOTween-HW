using DG.Tweening;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] private Vector3 _endRotation;
    [SerializeField] private float _duration;

    private void Start()
    {
        transform.DORotate(_endRotation, _duration).SetLoops(-1, LoopType.Incremental).SetEase(Ease.Linear);
    }
}
