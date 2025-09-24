using DG.Tweening;
using EditorAttributes;
using UnityEngine;

public class PureAnimation : MonoBehaviour
{
    public AnimationCurve XCurve;
    public AnimationCurve YCurve;
    public Vector2 Start;
    public Vector2 End;
    public float Duration = 1f;
    public Ease Ease = Ease.Linear;

    public Vector2 NormalToWorld(float normal)
    {
        float x = Mathf.LerpUnclamped(Start.x, End.x, XCurve.Evaluate(normal));
        float y = Mathf.LerpUnclamped(Start.y, End.y, YCurve.Evaluate(normal));
        return new Vector2(x, y);
    }

    // Запускает анимацию с помощью DOTween
    [Button]
    public void Animate()
    {
        float normalized = 0f;
        DOTween.To(() => normalized, x =>
        {
            normalized = x;
            Vector2 pos = NormalToWorld(normalized);
            transform.position = new Vector3(pos.x, pos.y, transform.position.z);
        }, 1f, Duration)
        .SetEase(Ease); // Линейное изменение параметра времени, а кривые задают итоговые позиции
    }
}

