using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneSwitcher : MonoBehaviour
{

    [SerializeField]
    private Transform[] _worlds;

    private int _activeWorld;

    private void Start()
    {
        _worlds = new Transform[transform.childCount];
        for (int i = 0; i < _worlds.Length; i++)
        {
            _worlds[i] = transform.GetChild(i);
            if (i == 0)
                _worlds[i].gameObject.SetActive(true);
            else
                _worlds[i].gameObject.SetActive(false);
        }

        _activeWorld = 0;

    }

    public void SwitchWorld()
    {
        if (_activeWorld + 1 < _worlds.Length)
        {
            _worlds[_activeWorld].gameObject.SetActive(false);
            _activeWorld++;
            _worlds[_activeWorld].gameObject.SetActive(true);
        }
        else
        {
            _worlds[_activeWorld].gameObject.SetActive(false);
            _activeWorld = 0;
            _worlds[_activeWorld].gameObject.SetActive(true);
        }



    }


}
