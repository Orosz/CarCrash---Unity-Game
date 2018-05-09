using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dreamcar01Track : MonoBehaviour {

    public GameObject TheMarker;
    public GameObject[] TrackMarks = new GameObject[61];
    public int MarkTracker;

	// Update is called once per frame
	void Update () {

        for (int i = 0; i < TrackMarks.Length; i++)
        {
            if (MarkTracker == i)
            {
                TheMarker.transform.position = TrackMarks[i].transform.position;
            }

        }

    }

    IEnumerator OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Dreamcar01")
        {
            this.GetComponent<BoxCollider>().enabled = false;
            MarkTracker += 1;
            if (MarkTracker == 60)
            {
                MarkTracker = 0;
            }
            yield return new WaitForSeconds(1);
            this.GetComponent<BoxCollider>().enabled = true;
        }
    }
}
