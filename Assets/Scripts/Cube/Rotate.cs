using System;
using System.Collections;
using System.Collections.Generic;
using Pattern;
using UnityEngine;

public class Rotate : Singleton<Rotate>
{
    private void Update()
    {
     transform.Rotate(new Vector3(90f * Time.deltaTime,0), Space.World);
    }
}
