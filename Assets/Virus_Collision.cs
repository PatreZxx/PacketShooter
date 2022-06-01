using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
using UnityEngine.UI;
using System.Collections.Generic;

public class Virus_Collision : MonoBehaviour
{
    float position_x;
    float position_z;
    float position_y;
    
    int timeRemaining;

    [SerializeField]
    Text Score;

    [SerializeField]
    public Text countdown;

    public Rigidbody rb;
    //Virus1 = gameObject.tag = "Virus";
    //virus1 = GameObject.FindGameObjectsWithTag("Virus");
    //rb = GetComponent<Rigidbody>();
    //Random rnd = new Random();
    //void Update()
    //{
    //   int random_number = Random.Range(0, 10);
    //  if (random_number == 10)
    //  {
    //rb.useGravity = true;
    //gameObject.GetComponent().useGravity = true;
    //GameObject.GetComponent<Rigidbody>().useGravity = true;
    //     rb.useGravity = true;
    //  }
    // }
        
        public class colors
        {
            public Color myColor;
            public Renderer myRenderer;
            public int color_r;
            public int color_g;
            public int color_b;
            public int color_a;
        }

         public class position
         {
             public static float x;
             public static float y;
             public static float z;
         }
        

    void Farba()
    {
            string[] viruses = { "Virus1", "Virus2", "Virus3", "Virus4", "Virus5", "Virus6", "Virus7", "Virus8", "Virus9", "Virus10" };
            //GameObject cube = GameObject.FindWithTag("Virus");
            //var cubeRenderer = cube.GetComponent<Renderer>();
            //colors color = new colors();
            for(int i = 0; i < 10; i++)
            {
            GameObject.FindWithTag(viruses[i]).GetComponent<Rigidbody>().drag = 4;
            int random_num = Random.Range(0, 11);
                if (random_num <= 2)
                {
                    //gameObject.GetComponent<Renderer>().material.color = "green";
                    //color.color_r = 0;
                    //color.color_g = 255;
                    //color.color_b = 0;
                    //color.color_a = 0;
                    //cubeRenderer.material.SetColor("_Color", Color.green);
                    GameObject.FindWithTag(viruses[i]).GetComponent<Renderer>().material.color = new Color(0, 255, 0);
                }
                else if (random_num > 2)
                {
                    //gameObject.GetComponent<Renderer>().material.color = "red";
                    //color.color_r = 255;
                    //color.color_g = 0;
                    //color.color_b = 0;
                    //color.color_a = 0;
                    //cubeRenderer.material.SetColor("_Color", Color.red);
                    GameObject.FindWithTag(viruses[i]).GetComponent<Renderer>().material.color = new Color(255, 0, 0); 
                }
                //color.myColor = new Color(color.color_r, color.color_g, color.color_b, color.color_a);
                //color.myRenderer.material.color = color.myColor;
            }
    }

    //void Padanie()
    //{
    //    GetComponent<Rigidbody>().useGravity = false;
    //    IEnumerator waiter_not_that_waiter_just_waiter()
    //    {
    //        yield return new WaitForSeconds(1f);
    //    }
    //    string loop = "yes";
    //  string[] viruses = { "Virus1", "Virus2", "Virus3", "Virus4", "Virus5", "Virus6", "Virus7", "Virus8", "Virus9", "Virus10" };
    //    for (int i = 0; i < 11; i++)
    //    {
    //        while(loop == "yes")
    //        {
    //            int random_num = Random.Range(0, 11);
    //            if (random_num < 9)
    //            {
    //                GameObject.FindWithTag(viruses[i]).GetComponent<Rigidbody>().useGravity = true;
    //            }
    //            if (random_num > 8)
    //            {
    //                StartCoroutine(waiter_not_that_waiter_just_waiter());
    //            }
    //        }
    //    }
    //}

    void Update()
    {
        countdown.text = timeRemaining.ToString();
        /*if (Input.GetKeyDown("escape"))
        {
            countdown.GetComponent<Text>().color = Color.red;
            countdown.text = "Game Over!";
            string[] viruses = { "Virus1", "Virus2", "Virus3", "Virus4", "Virus5", "Virus6", "Virus7", "Virus8", "Virus9", "Virus10" };
            for (int i = 0; i < 10; i++)
            {
                Destroy(GameObject.FindWithTag(viruses[i]));
            }
        }*/
    }


    float startTime = 60;
    float time;

    private void Start()
    {
        //time = startTime;
        int time = int.Parse(countdown.text);
        Farba();
        position_x = transform.position.x;
        position_y = transform.position.y;
        position_z = transform.position.z;
        InvokeRepeating("clock", 0f, 1f);
    }
    /*
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("In OnTriggerEnter function");
        if( (this.gameObject.GetComponent<Renderer>().material.color).ToString() == "RGBA(255.000, 0.000, 0.000, 1.000)")
        {
            Debug.Log("In OnTriggerEnter function IF statement");
            Subtract();
        }
    }
    */
    /*
    void CountDown()
    {
        if(time < 0)
        {
            countdown.GetComponent<Text>().color = Color.red;
            countdown.text = "YOU LOST!";
            string[] viruses = { "Virus1", "Virus2", "Virus3", "Virus4", "Virus5", "Virus6", "Virus7", "Virus8", "Virus9", "Virus10" };
            for (int i = 0; i < 10; i++)
            {
                Destroy(GameObject.FindWithTag(viruses[i]));
            }
        }
        else
        {
            time = float.Parse(countdown.text);
            time = time - 1;
        }
    }

    public void Add()
    {
        time = time + 5;
    }

    public void Subtract()
    {
        time = time - 5;
        Debug.Log("Subtracted 5s");
    }
    */
    
    void clock()
    {
        timeRemaining = int.Parse(countdown.text);
        //Debug.Log(timeRemaining);
        timeRemaining = timeRemaining - 1;
        if (timeRemaining < 0)
        {
            countdown.GetComponent<Text>().color = Color.red;
            countdown.text = "Game Over!";
            string[] viruses = { "Virus1", "Virus2", "Virus3", "Virus4", "Virus5", "Virus6", "Virus7", "Virus8", "Virus9", "Virus10" };
            for (int i = 0; i < 10; i++)
            {
                Destroy(GameObject.FindWithTag(viruses[i]));
            }
        }
        //countdown.text = timeRemaining.ToString();
    }
    

    /*
    public void Start()
    {
        Farba();
        //Padanie();
        //position position = new position();
        //string[] viruses = { "Virus1", "Virus2", "Virus3", "Virus4", "Virus5", "Virus6", "Virus7", "Virus8", "Virus9", "Virus10" };
        //for (int i = 0; i < 11; i++){GameObject.FindWithTag(viruses[i]).GetComponent<Rigidbody>().useGravity = false;}
        //IEnumerator waiter_not_that_waiter_just_waiter()
        //{
        //    yield return new WaitForSeconds(1f);
        //}
        //int rnd = Random.Range(0, 2);
        //if(rnd == 0)
        //{
        //    this.GameObject.GetComponent<Rigidbody>().useGravity = false;
        //    StartCoroutine(waiter_not_that_waiter_just_waiter());
        //    this.GameObject.GetComponent<Rigidbody>().useGravity = true;
        //}
        position_x = transform.position.x;
        position_y = transform.position.y;
        position_z = transform.position.z;
        //Debug.Log(position_x);
        //Debug.Log(position_y);
        //Debug.Log(position_z);
        InvokeRepeating("clock", 0f, 1f);
    }
    */

    /*
    void add()
    {
        countdown.text = (int.Parse(countdown.text) +5).ToString();
    }
    */

    /*
    void subtract()
    {
        countdown.text = (int.Parse(countdown.text) - 10).ToString();
    }
    */

    //public void OnTriggerEnter(Collider other)
    //{
    // if( (this.gameObject.GetComponent<Renderer>().material.color).ToString() == "RGBA(0.000, 255.000, 0.000, 1.000)")
    //{
    //    add();
    // }
    //if( (this.gameObject.GetComponent<Renderer>().material.color).ToString() == "RGBA(255.000, 0.000, 0.000, 1.000)")
    //{
    //     subtract();
    // }
    // }

    //void OnTriggerEnter(Collider other)
    //{
    //    if((other.gameObject.GetComponent<Renderer>().material.color).ToString() == "RGBA(0.000, 255.000, 0.000, 1.000)")
    //    {
    //        countdown.text = (int.Parse(countdown.text) + 5).ToString();
    //    }
    //    if((other.gameObject.GetComponent<Renderer>().material.color).ToString() == "RGBA(255.000, 0.000, 0.000, 1.000)")
    //    {
    //        countdown.text = (int.Parse(countdown.text) - 10).ToString();
    //    }
    //}

    //void OnCollisionEnter(Collision collision)
    //{
    //    if ((collision.gameObject.GetComponent<Renderer>().material.color).ToString() == "RGBA(255.000, 0.000, 0.000, 1.000)")
    //    {
    //        countdown.text = (int.Parse(countdown.text) - 10).ToString();
    //    }
    //    if ((collision.gameObject.GetComponent<Renderer>().material.color).ToString() == "RGBA(0.000, 255.000, 0.000, 1.000)")
    //    {
    //        countdown.text = (int.Parse(countdown.text) + 5).ToString();
    //    }
    //}

    //void Update()
    //{
    // if(is_falling == "no")
    //{
    //   int random_number = Random.Range(0, 2);
    //  string[] viruses = { "Virus1", "Virus2", "Virus3", "Virus4", "Virus5", "Virus6", "Virus7", "Virus8", "Virus9", "Virus10" };
    //  IEnumerator waiter_not_that_waiter_just_waiter()
    //  {
    //      yield return new WaitForSeconds(1f);
    //  }
    //  string[] viruses = { "Virus1", "Virus2", "Virus3", "Virus4", "Virus5", "Virus6", "Virus7", "Virus8", "Virus9", "Virus10" };
    //  for (int i = 0; i < 10; i++)
    //  {
    //      GameObject.FindWithTag(viruses[i]).GetComponent<Rigidbody>().useGravity = false;
    //      if (random_number == 0)
    //     {
    //         StartCoroutine(waiter_not_that_waiter_just_waiter());
    //        GameObject.FindWithTag(viruses[i]).GetComponent<Rigidbody>().useGravity = true;
    //        is_falling = "yes";
    //    }
    // }
    //  }
    // }

    void OnCollisionEnter(Collision collision)
    {
            //position position = new position();
            if (collision.gameObject.tag == "Terrain")
            {
                //Destroy(collision.gameObject);
                //Destroy(GameObject.FindWithTag("Virus"));
                //virus1.SetActive(false);
                //GameObject.FindGameObjectWithTag("Virus").SetActive(false);
                //Debug.Log(position_x);
                //Debug.Log(position_y);
                //Debug.Log(position_z);
                IEnumerator waiter_not_that_waiter_just_waiter()
                {
                    /*
                    if((this.gameObject.GetComponent<Renderer>().material.color).ToString() == "RGBA(255.000, 0.000, 0.000, 1.000)")
                    {
                        Subtract();
                    }
                    */

                    //gameObject.SetActive(false);
                    //Debug.Log("Vo funkcii a idem �aka� 1sec");
                    yield return new WaitForSeconds(1f);
                    //Debug.Log("Po�kal som 1 sec");
                    gameObject.SetActive(true);
                    transform.position = new Vector3(position_x, position_y, position_z);
                    //transform.position.x = position.x;
                    //transform.position.y = position.y;
                    //transform.position.z = position.z;
                }
                gameObject.SetActive(true);
                StartCoroutine(waiter_not_that_waiter_just_waiter());
                waiter_not_that_waiter_just_waiter();
            }

            else if (collision.gameObject.tag == "Bullet")
            {
                //string[] viruses = { "Virus1", "Virus2", "Virus3", "Virus4", "Virus5", "Virus6", "Virus7", "Virus8", "Virus9", "Virus10" };
                //for(int i = 0; i < 10; i++)
                //{
                // if (collision.gameObject.tag == viruses[i]) 
                //{
                //  if ( (GameObject.FindWithTag(viruses[i]).GetComponent<Renderer>().material.color).ToString() == "RGBA(0.000, 255.000, 0.000, 1.000)")
                //  {
                //      Debug.Log(Score.text);
                //      Score.text = (int.Parse(Score.text) + 1).ToString();
                //  }
                // if ( (GameObject.FindWithTag(viruses[i]).GetComponent<Renderer>().material.color).ToString() == "RGBA(255.000, 0.000, 0.000, 1.000)")
                // {
                //     Debug.Log(Score.text);
                //     Score.text = (int.Parse(Score.text) - 2).ToString();
                // }
                //}
                //

                

                collision.gameObject.GetComponent<Renderer>().material.color = this.gameObject.GetComponent<Renderer>().material.color;
                if ((collision.gameObject.GetComponent<Renderer>().material.color).ToString() == "RGBA(0.000, 255.000, 0.000, 1.000)")
                {
                    Score.text = (int.Parse(Score.text) - 3).ToString();
                    //add();
                }
                if ((collision.gameObject.GetComponent<Renderer>().material.color).ToString() == "RGBA(255.000, 0.000, 0.000, 1.000)")
                {
                    Score.text = (int.Parse(Score.text) + 1).ToString();
                    //subtract();
                }
                int random_num = Random.Range(0, 11);
                if (random_num <= 2)
                {
                    this.gameObject.GetComponent<Renderer>().material.color = new Color(0, 255, 0);
                }
                if (random_num > 2)
                {
                    this.gameObject.GetComponent<Renderer>().material.color = new Color(255, 0, 0);
                }
                IEnumerator waiter_not_that_waiter_just_waiter()
                {
                    //Debug.Log("Vo funkcii a idem �aka� 1sec");
                    yield return new WaitForSeconds(1f);
                    //Debug.Log("Po�kal som 1 sec");
                }
                transform.position = new Vector3(position_x, position_y, position_z);
                transform.rotation = Quaternion.Euler(0, 0, 0);
                StartCoroutine(waiter_not_that_waiter_just_waiter());
                Destroy(collision.gameObject);
            }
    }
}
