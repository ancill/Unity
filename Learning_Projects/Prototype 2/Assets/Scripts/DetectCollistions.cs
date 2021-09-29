using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollistions : MonoBehaviour
{
  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {

  }

  void OnTriggerEntered(Collider other)
  {
    Destroy(gameObject);
    Destroy(other.gameObject);
  }
}
