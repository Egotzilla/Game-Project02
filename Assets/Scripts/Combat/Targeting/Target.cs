using System;
using UnityEngine;

public class Target : MonoBehaviour
{
    // Event triggered when the target is destroyed
    public event Action<Target> OnDestroyed;

    private void OnDestroy()
    {
        OnDestroyed?.Invoke(this);
    }
}
