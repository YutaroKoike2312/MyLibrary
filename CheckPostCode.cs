using UnityEngine;
using MyLibrary;

public class CheckPostCode : MonoBehaviour
{
    void Start()
    {
        Debug.Log(PostalCodeValidator.IsValidPostalCode("123-123"));
        Debug.Log(PostalCodeValidator.IsValidPostalCode("123-1234"));
    }
}