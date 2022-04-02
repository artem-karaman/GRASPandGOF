using Core.Composite;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private Button _displayMenuButton;

    void Start()
    {
        IComponent menu = new Composite("root");
        IComponent menu1 = new Composite("menu 1");
        IComponent menu2 = new Composite("menu 2");

        menu1.Add(new Leaf("button1"));
        menu1.Add(new Leaf("button2"));
        menu1.Add(new Leaf("button3"));
        menu1.Add(new Leaf("button4"));

        menu2.Add(new Leaf("button5"));
        menu2.Add(new Leaf("button6"));

        menu.Add(menu1);
        menu.Add(menu2);

        _displayMenuButton
            .onClick
            .AddListener(() => _text.text = menu.Display());
    }
}
