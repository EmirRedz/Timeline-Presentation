using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class ShipMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.DOMove(transform.forward * 300, 35f);
    }
    
}
