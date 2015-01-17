using UnityEngine;

public class Visualizer : MonoBehaviour {

    public void ChangeVisual(float pitch)
    {
        float value = pitch/1000;
        if (value < 0.1) value = 0.1f;
        transform.localScale = new Vector3(value, value, value);
    }
}
