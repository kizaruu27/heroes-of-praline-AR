using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class FlipMesh : MonoBehaviour
{
   private Mesh _mesh;

   private void Start()
   {
      _mesh = GetComponent<MeshFilter>().sharedMesh;
   }
}
