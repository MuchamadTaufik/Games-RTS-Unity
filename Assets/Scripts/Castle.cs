using System.Collections;
using UnityEngine;

public class Castle : MonoBehaviour
{
    void OnTriggerEnter2D (Collider2D other) {
        if (other.tag == "Player") {
            Application.LoadLevel("Win");
        }
    }
}
