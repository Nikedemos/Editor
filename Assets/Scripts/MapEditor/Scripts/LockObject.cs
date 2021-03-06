﻿using UnityEngine;

[ExecuteAlways]
public class LockObject : MonoBehaviour
{
    private Vector3 position;
    private Vector3 scale;
    private Quaternion rotation;
    public bool locked;

    private void OnEnable()
    {
        position = transform.localPosition;
        scale = transform.localScale;
        rotation = transform.localRotation;
        locked = true;
    }
    private void Update ()
    {
        if (locked)
        {
            if (transform.localPosition != position)
            {
                transform.localPosition = position;
            }
            if (transform.localScale != scale)
            {
                transform.localScale = scale;
            }
            if (transform.localRotation != rotation)
            {
                transform.localRotation = rotation;
            }
        }
        else
        {
            position = transform.localPosition;
            scale = transform.localScale;
            rotation = transform.localRotation;
        }
    }
    public void Lock()
    {
        locked = true;
    }
    public void Unlock()
    {
        locked = false;
    }
    /// <summary>
    /// Moves the locked object to a new position.
    /// </summary>
    /// <param name="position">Local position to set the object to.</param>
    public void SetPosition(Vector3 pos)
    {
        position = pos;
    }
    /// <summary>
    /// Rotates the locked object to a new rotation.
    /// </summary>
    /// <param name="rot">Local rotation to set the object to.</param>
    public void SetRotation(Quaternion rot)
    {
        rotation = rot;
    }
    /// <summary>
    /// Scales the locked object to a new size.
    /// </summary>
    /// <param name="scl">Local scale to set the object to.</param>
    public void SetScale(Vector3 scl)
    {
        scale = scl;
    }
}