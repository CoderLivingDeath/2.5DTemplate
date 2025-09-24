using Cysharp.Threading.Tasks;
using System;
using System.Threading;
using UnityEngine;

public abstract class ViewAnimation<T> : IViewAnimation where T : MonoCanvasView
{
    public T View { get; }

    public float Duration { get; set; } = 1f;

    MonoCanvasView IViewAnimation.View => View;

    protected ViewAnimation(T view)
    {
        View = view ?? throw new ArgumentNullException(nameof(view));
    }

    public abstract UniTask AnimateAsync(CancellationToken token = default);

}
