using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book : MonoBehaviour
{
    [SerializeField] private Material _page0Material;
    [SerializeField] private Material _page1Material;
    [SerializeField] private List<Material> _materialsList;
    [SerializeField] private Texture[] _pages;
    [SerializeField] private Renderer _renderer;
    [SerializeField] private int _currentPage;

    private void Start()
    {
        _renderer.GetMaterials(_materialsList);
        UpdatePages();
    }

    public void FlipPageLeft()
    {
        if (_currentPage <= 1)
            return;
        _currentPage -= 2;
        UpdatePages();
    }

    public void FlipPageRight()
    {
        if (_currentPage >= _pages.Length - 2)
            return;
        _currentPage += 2;
        UpdatePages();
    }

    private void UpdatePages()
    {
        _materialsList[0].mainTexture = _pages[_currentPage];

        if (_currentPage < _pages.Length - 1)
            _materialsList[2].mainTexture = _pages[_currentPage + 1];
        else
            _materialsList[2].mainTexture = null;
    }
}
