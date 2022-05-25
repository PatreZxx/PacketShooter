using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Terrain_collision : MonoBehaviour
{
    [SerializeField]
    Text Score;

    [SerializeField]
    public Text countdown;
    
    /*
    void add()
    {
        countdown.text = (int.Parse(countdown.text) + 5).ToString();
    }

    void subtract()
    {
        countdown.text = (int.Parse(countdown.text) - 10).ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if ( (other.gameObject.GetComponent<Renderer>().material.color).ToString() == "RGBA(255.000, 0.000, 0.000, 1.000)")
        {
            subtract();
        }
    }
    */
    void OnCollisionEnter(Collision collision)
    {
            if (collision.gameObject.tag == "Bullet")
            {
            Destroy(collision.gameObject);
            }
            //Debug.Log(collision.gameObject.GetComponent<Renderer>().material.color);
            collision.gameObject.GetComponent<Rigidbody>().freezeRotation = true;
            collision.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            if ( (collision.gameObject.GetComponent<Renderer>().material.color).ToString() == "RGBA(0.000, 255.000, 0.000, 1.000)")
            {
                Score.text = (int.Parse(Score.text) + 1).ToString();
                //add();
                //Debug.Log("+5");
            }
            if ( (collision.gameObject.GetComponent<Renderer>().material.color).ToString() == "RGBA(255.000, 0.000, 0.000, 1.000)")
            {
                Score.text = (int.Parse(Score.text) - 2).ToString();
                //subtract();
                //Debug.Log("-10");
            }
            int random_num = Random.Range(0, 11);
            string[] viruses = { "Virus1", "Virus2", "Virus3", "Virus4", "Virus5", "Virus6", "Virus7", "Virus8", "Virus9", "Virus10" };
            for (int i = 0; i < 10; i++)
            {
                if(collision.gameObject.tag == viruses[i])
                    if (random_num < 9)
                    {
                        collision.gameObject.GetComponent<Renderer>().material.color = new Color(0, 255, 0);
                    }
                    if (random_num > 8)
                    {
                        collision.gameObject.GetComponent<Renderer>().material.color = new Color(255, 0, 0);
                    }
            }
    }
}