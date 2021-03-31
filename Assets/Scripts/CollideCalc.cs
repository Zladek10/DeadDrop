using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollideCalc : MonoBehaviour
{
    public GameObject enemy;

    public GameObject path;

    public GameObject path1;

    public GameObject path2;

    public GameObject pathEdge;

    public GameObject path4;

    public GameObject path5;

    public GameObject path6;

    public GameObject obstacle;


    int turnCount;



    // Start is called before the first frame update
    void Start()
    {
        turnCount = 0;

        enemy.transform.Rotate(0, 0, 0);

        obstacle.GetComponent<BoxCollider>().enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        //Quaternion myRotation = enemy.transform.rotation;

        //Debug.Log(myRotation.eulerAngles.y);

        //Debug.Log("Update Working");

        //if (enemy.transform.rotation.y == -180)
        //{
        //    Debug.Log("Collider Got Up");

        //    obstacle.GetComponent<BoxCollider>().enabled = true;
        //}
        

    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("path"))
        {
            transform.position = path.transform.position;

            turnCount++;

            enemy.transform.Rotate(0, +90, 0);
        }

        if (other.CompareTag("path1"))
        {
            transform.position = path1.transform.position;

            turnCount++;

            enemy.transform.Rotate(0, +90, 0);
        }

        if (other.CompareTag("path2"))
        {
            transform.position = path2.transform.position;

            turnCount++;

            enemy.transform.Rotate(0, +90, 0);
        }

        if (other.CompareTag("pathedge"))
        {
            transform.position = pathEdge.transform.position;

            turnCount++;

            enemy.transform.Rotate(0, +90, 0);
        }

        if (other.CompareTag("path4"))
        {
            transform.position = path4.transform.position;

            turnCount++;

            enemy.transform.Rotate(0, +90, 0);
        }

        if (other.CompareTag("path5"))
        {
            transform.position = path5.transform.position;

            turnCount++;

            enemy.transform.Rotate(0, +90, 0);
        }

        if (other.CompareTag("path6"))
        {
            transform.position = path6.transform.position;

            SceneManager.LoadScene("Level 2");
        }

        


        


    }



    public void EnemyRotate()
    {
        enemy.transform.Rotate(0, +90, 0);
    }


    public void GoToMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
