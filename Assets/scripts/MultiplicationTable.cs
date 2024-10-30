using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class MultiplicationTable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int  MultiplicationForNum =5;
        Debug.Log("5’s multiplication table:");
        for (int index=1; index<=10; index++){

        int multiplicationResult=Multiply(MultiplicationForNum,index);
        Debug.Log(MultiplicationForNum+ " * "+index +" = "+multiplicationResult);


        }
        
    }

   int Multiply(int num1, int num2){

    int multiplyResult=num1*num2;
    return multiplyResult;


   }
}
