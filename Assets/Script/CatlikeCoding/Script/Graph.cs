using System;
using UnityEngine;

public class Graph : MonoBehaviour
{
    [SerializeField] Transform pointPrefab;
    [SerializeField, Range(10, 100)] int resolution = 10;

    Transform[] points;
    private float step = 0;
    void Start()
    {
        step = 2f / resolution;
        //Vector3 position = Vector3.zero;
        var scale = Vector3.one * step;
        points = new Transform[resolution];
        for (int i = 0; i < resolution; i++)
        {
            Transform point = Instantiate(pointPrefab);
            points[i] = point;
            point.localScale = scale;
            point.SetParent(transform);
        }

     
    }

    private void Update()
    {
        float time = Time.time;
        for (int i = 0; i < points.Length; i++)
        {
            Transform point = points[i];
            Vector3 position = point.localPosition;
            position.x = (i + 0.5f) * step - 1f;
            position.y = Mathf.Sin(Mathf.PI * (position.x + time));
            point.localPosition = position;
        }
    }
}