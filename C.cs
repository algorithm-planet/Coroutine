public class C
{
    public float dt = 1f/50,
                  v = 2f;
    public WaitForSecond wait { get{return new WaitForSeconds(dt)} };
    
    public Coroutine PARALELL(paramas IEnumerator[] E)
    {
        for(int i = 1;  i < E.Length ;i += 1)
            start(E[i]);
        return start(E[0]);
    }
    
    //..........start()
    public Coroutine start(IEnumerator e)
    {
        return SCENE._ref_.StartCoroutine(e);
    }
}

public class SCENE : MonoBehaviour
{
    public static SCENE _ref_;
    void Start()
    {
        _ref_ = this;
        C.start(/*  */);
    }
}
