using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debugger : MonoBehaviour
{
    // Start is called before the first frame update
    IEnumerator Start()
    {
        Health health = GetComponent<Health>();
        Level level = GetComponent<Level>();

        while (true)
        {
            yield return new WaitForSeconds(1);
            Debug.Log($"Exp: {level.GetExperience()}, Level: {level.GetLevel()}, Health: {health.GetHealth()}");
        }
    }


}
