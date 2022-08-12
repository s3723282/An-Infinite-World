using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockScript : MonoBehaviour
{
    public GameObject objectToSpawn;

    bool probabilityOfSpawn => Random.Range(0, 100) >= 32 && Random.Range(0, 100) <= 45;

    void Start()
    {
        if (this.transform.position.y <= 2.0f &&
            this.transform.position.y >= 1.5f &&
            probabilityOfSpawn)
        {
            Instantiate(
                objectToSpawn, new Vector3(
                    this.transform.position.x,
                    this.transform.position.y + 1.5f,
                    this.transform.position.z
                    ), Quaternion.identity
                );
        }
           
             if(probabilityOfSpawn) {
                 Instantiate(objectToSpawn, new Vector3(
                        this.transform.position.x, 
                        this.transform.position.y, 
                        this.transform.position.z
                   ), Quaternion.identity
                );
            }   
        }
    }