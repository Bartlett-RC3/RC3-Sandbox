﻿using System;
using UnityEngine;
using UnityEditor;

namespace SpatialSlur.Unity.MeshProcessing
{
    /// <summary>
    /// 
    /// </summary>
    [CustomEditor(typeof(SharedHeMesh3d))]
    public class SharedHeMesh3dEditor : Editor
    {
        /// <summary>
        /// 
        /// </summary>
        public override void OnInspectorGUI()
        {
            var mesh = (SharedHeMesh3d)target;
            EditorGUILayout.LabelField(mesh.Value.ToString());
        }
    }
}
