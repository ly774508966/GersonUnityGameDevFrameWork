﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RayCastImage : Image
{
    protected override void OnPopulateMesh(VertexHelper toFill)
    {
        toFill.Clear();
    }
}
