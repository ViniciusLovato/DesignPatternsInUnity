using System;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private Vector3 speed;

    public Action<Bullet> Disable;
        
    // Update is called once per frame
    void Update()
    {
        transform.position += speed * Time.deltaTime;
    }
    
    private void OnBecameInvisible()
    {
        Disable?.Invoke(this);
    }
}
