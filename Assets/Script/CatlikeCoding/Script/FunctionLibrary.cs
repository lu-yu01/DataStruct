using UnityEngine;
using static UnityEngine.Mathf;

public static class FunctionLibrary
{
    public static float Wave(float x, float t)
    {
        return Sin(Mathf.PI * (x + t));
    }

    public static float MultiWave(float x, float t)
    {
        float y = Sin(PI * (x + t));
        y += Sin(2f * PI * (x + t)) / 2f;
        return y/1.5f;
    }
}