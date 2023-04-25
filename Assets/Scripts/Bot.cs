using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bot : MonoBehaviour
{
    private string[] _names = { "Mario", "Peach", "Bowser", "Luigi", "Toad", "Donkey Kong" };

    private Humano _humano;
    private UIScript _uiScript;

    private void Start()
    {
        _humano = GameObject.Find("Human").GetComponent<Humano>();
        _uiScript = GameObject.Find("Canvas").GetComponent<UIScript>();
    }

    void Saludar()
    {
        string newName = _names[Random.Range(0, _names.Length)];
        Debug.Log($"Hola {_humano.nombre} ahora te llamas {newName}");
        _uiScript.ShowGrettings($"Hola {_humano.nombre} ahora te llamas {newName}");
        _humano.nombre = newName;
    }

    public void OnTriggerEnter(Collider other)
    {
        Saludar();
        Destroy(gameObject);
    }
}
