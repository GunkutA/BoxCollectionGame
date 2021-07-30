using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Sphere1 : MonoBehaviour
{
    public int speed = 100;
    Rigidbody RB;
    int score;
    int congratsScore = 10;
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        RB=GetComponent<Rigidbody>();
        score = 0;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        float H = Input.GetAxisRaw("Horizontal");
        float V = Input.GetAxisRaw("Vertical");
        Vector3 vec = new Vector3(H, 0 , V);
        RB.AddForce(vec *speed*Time.deltaTime);

        
    }
    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag=="Cube")
        {
            col.gameObject.SetActive(false);
            score++;
            scoreText.text = "Score:" + score;
        }
        else if(col.gameObject.tag=="Wall")
        {
            score--;
            scoreText.text = "Score:" + score;
        }

        if(score == congratsScore)
        {
            scoreText.text = "Congratulations ;)";
        }
        

    }
}
