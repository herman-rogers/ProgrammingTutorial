using UnityEngine;
using System.Collections;

public class ConsoleOutput : MonoBehaviour {


    int myWord = 1;
    int numberTwo = 0;

    void Start( ) {
        test( );
    }
    
    void test( ) {
        myWord = myWord + myWord;
        Debug.Log( myWord );
    }

}

public class NewClass : MonoBehaviour { 

}