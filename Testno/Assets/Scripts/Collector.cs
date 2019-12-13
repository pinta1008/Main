using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collector : MonoBehaviour
{
    public int skupljeni_Coinsi;
    public Text textCoins;
    public AudioSource zvuk;
    int brojCoinsaNaSceni;
    public Text textTime;
    public float vrijeme;

    private void Start()
    {
        brojCoinsaNaSceni = GameObject.FindGameObjectsWithTag("Collectable").Length;
        textCoins.text = skupljeni_Coinsi + "/" + brojCoinsaNaSceni;
        vrijeme = brojCoinsaNaSceni * 45;
        

    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Collectable")
        {
            Destroy(other.gameObject);
            skupljeni_Coinsi++;
            textCoins.text = skupljeni_Coinsi + "/" + brojCoinsaNaSceni;
            zvuk.Play();
        }
    }

    void Update()
    {
        vrijeme -= 1f * Time.deltaTime;
        textTime.text = vrijeme.ToString("0") + " ";
       
    }



}
