public float myVar;

    void Start()
    {
        Debug.Log("It's a test");
        print("it's another test");
        myVar = Random.Range(0f, 100f);
        Debug.log(myVar);
    }