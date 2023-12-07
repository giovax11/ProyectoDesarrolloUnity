using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteScript : MonoBehaviour
{
    private bool noteStatus;
    public GameObject note;
    // Start is called before the first frame update
    public void ToggleNote()
    {
        noteStatus = !noteStatus;
        note.SetActive(noteStatus);
    }

    // Update is called once per frame
    public bool GetNoteStatus()
    {
        return noteStatus;
    }
}
