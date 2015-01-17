using UnityEngine;

public class Visualizer : MonoBehaviour {

    public void ChangeVisual(float analyzed)
    {
        float value = analyzed / 25;
        if (value < 0.1) value = 0.1f;
        transform.localScale = new Vector3(value, 1f, 1f);
    }
}
