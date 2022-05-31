using UnityEngine;
using Zenject;

public class InputAdapter : MonoBehaviour
{
    private KnifeKeeper _knifeKeeper;

    [Inject]
    public void Init(KnifeKeeper knifeKeeper)
    {
        _knifeKeeper = knifeKeeper;
    }

    private void Update()
    {
        #if UNITY_ANDROID
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
            ThrowKnife();
        #endif

        #if UNITY_EDITOR
        if (Input.GetMouseButton(0))
            ThrowKnife();
        #endif
    }

    private void ThrowKnife()
    {
        _knifeKeeper.ThrowKnife();
    }
}
