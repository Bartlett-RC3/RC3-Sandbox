﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Notes
 */ 

namespace RC3
{
    /// <summary>
    /// Simple adjacency list representation of an undirected graph.
    /// </summary>
    public class Graph : IGraph
    {
        #region Static
        
        public static readonly GraphFactory Factory = new GraphFactory();
        private const int _defaultCapacity = 4;

        #endregion


        private List<List<int>> _vertices;


        /// <summary>
        /// 
        /// </summary>
        public Graph(int vertexCapacity = _defaultCapacity)
        {
            _vertices = new List<List<int>>(vertexCapacity);
        }


        /// <summary>
        /// Returns the number of vertices in the graph.
        /// </summary>
        public int VertexCount
        {
            get { return _vertices.Count; }
        }


        /// <summary>
        /// Returns the degree of the given vertex.
        /// </summary>
        public int GetDegree(int vertex)
        {
            return _vertices[vertex].Count;
        }


        /// <summary>
        /// Adds a new vertex to the graph.
        /// </summary>
        public void AddVertex(int capacity = _defaultCapacity)
        {
            _vertices.Add(new List<int>(capacity));
        }


        /// <summary>
        /// Adds an edge between the given vertices.
        /// </summary>
        public void AddEdge(int v0, int v1)
        {
            _vertices[v0].Add(v1);
            _vertices[v1].Add(v0);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="vertex"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public int GetConnectedVertex(int vertex, int index)
        {
            return _vertices[vertex][index];
        }


        /// <summary>
        /// Returns all vertices connected to the given vertex.
        /// </summary>
        public IEnumerable<int> GetConnectedVertices(int vertex)
        {
            return _vertices[vertex];
        }
    }
}