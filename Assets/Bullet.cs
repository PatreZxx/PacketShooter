using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    GameObject Player1;
    [SerializeField]
    GameObject Terrain1;
    [SerializeField]
    GameObject Bullet1;
    
    [SerializeField]
    Text Score;

    [SerializeField]
    Text countdown;

    public float life = 3;

    void Awake()
    {
        Destroy(gameObject, life);
    }

    void OnCollisionEnter(Collision collision)
    {
        //if((collision.gameObject != Player) and (collision.gameObject != Terrain)){
        if ( (collision.gameObject.tag == "Player") || (collision.gameObject.tag == "Terrain") )
        {
        }
        //string[] viruses = { "Virus1", "Virus2", "Virus3", "Virus4", "Virus5", "Virus6", "Virus7", "Virus8", "Virus9", "Virus10" };
        //for (int i = 0; i < 10; i++)
        //{
          //  if (collision.gameObject.tag == viruses[i])
           // {
           //     if ( (GameObject.FindWithTag(viruses[i]).GetComponent<Renderer>().material.color).ToString() == "RGBA(255.000, 0.000, 0.000, 1.000)")
           //     {
            //        GameObject.FindWithTag("Bullet").GetComponent<Renderer>().material.color = new Color(255, 0, 0);
            //    }
            //    if ( (GameObject.FindWithTag(viruses[i]).GetComponent<Renderer>().material.color).ToString() == "RGBA(0.000, 255.000, 0.000, 1.000)")
            //    {
            //        GameObject.FindWithTag("Bullet").GetComponent<Renderer>().material.color = new Color(0, 255, 0);
            //    }
           // }
        //}
        else
        {
            collision.gameObject.GetComponent<Rigidbody>().freezeRotation = true;
            collision.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            /*
            if((collision.gameObject.GetComponent<Renderer>().material.color).ToString() == "RGBA(0.000, 255.000, 0.000, 1.000)")
            {
                countdown.text = (int.Parse(countdown.text) + 5).ToString();
            }
            if ((collision.gameObject.GetComponent<Renderer>().material.color).ToString() == "RGBA(255.000, 0.000, 0.000, 1.000)")
            {
                countdown.text = (int.Parse(countdown.text) - 10).ToString();
            }
            */
                //color.myColor = new Color(color.color_r, color.color_g, color.color_b, color.color_a);
                //color.myRenderer.material.color = color.myColor;
        }
        //collision.gameObject.transform.position.x = position.x;
        //collision.gameObject.transform.position.y = position.y;
        //collision.gameObject.transform.position.z = position.z;
        //collision.gameObject.SetActive(true);
        //yield return new WaitForSeconds(4);
        //collision.gameObject.SetActive(true);
        //Destroy(GameObject.FindWithTag("Bullet"));
        //Destroy(collision.collider.gameObject);  float x = transform.position.x;
    }
        //if (collision.gameObject.tag != "Terrain") collision.gameObject.SetActive(false);
        //Destroy(collision.gameObject);
        // Destroy(gameObject); 
        //}
}
