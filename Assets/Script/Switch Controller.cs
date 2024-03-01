using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SwitchController : MonoBehaviour
{
    public Collider bola;
    public Material offMaterial;
    public Material onMaterial;
    public float score;
    public ScoreManager scoreManager;
    private bool isOn;
    private Renderer render;

    private void Start() 
    {
        render = GetComponent<Renderer>();
        Set(false);
    }
    private void OnTriggerEnter(Collider other) 
    {
        if (other == bola)
        {
            scoreManager.AddScore(score);
            StartCoroutine(Blink(2));
        }
    }

    private void Set(bool status)
    {
        isOn = status;
        render.material = isOn ? onMaterial : offMaterial;
    }

    private IEnumerator Blink(int times)
    {
        int blinkTimes = times * 2;

        for (int i = 0; i < blinkTimes; i++)
        {
            Set(!isOn);
        yield return new WaitForSeconds(0.5f);
        }
        Set(!isOn);
    }
}
