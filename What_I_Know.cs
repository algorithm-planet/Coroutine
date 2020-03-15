IEnumerator another =  @Object.move( next );

//Inside IEnumerator
//waits till its complete
yield return startCoroutine(another);
yield return wait(sec);

//no wait
startCoroutine(another)

// startCorutine is a Coroutine ......... can be called only by SCENE
Coroutine PARALELL = startCorutine(another);
