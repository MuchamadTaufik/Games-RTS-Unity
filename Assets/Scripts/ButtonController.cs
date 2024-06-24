/* using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonController : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public Button jumpButton;
    public Button leftButton;
    public Button rightButton;

    private Player playerScript;
    private bool isLeftButtonDown;
    private bool isRightButtonDown;

    private void Start()
    {
        playerScript = FindObjectOfType<Player>();

        // Menghubungkan tombol dengan fungsi pemain yang sesuai
        jumpButton.onClick.AddListener(playerScript.Jump);
        leftButton.onClick.AddListener(OnLeftButtonClick);
        rightButton.onClick.AddListener(OnRightButtonClick);
    }

    private void Update()
    {
        if (isLeftButtonDown && !isRightButtonDown)
        {
            playerScript.WalkLeft();
        }
        else if (isRightButtonDown && !isLeftButtonDown)
        {
            playerScript.WalkRight();
        }
        else
        {
            playerScript.StopWalk();
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (eventData.pointerCurrentRaycast.gameObject == leftButton.gameObject)
        {
            isLeftButtonDown = true;
        }
        else if (eventData.pointerCurrentRaycast.gameObject == rightButton.gameObject)
        {
            isRightButtonDown = true;
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if (eventData.pointerCurrentRaycast.gameObject == leftButton.gameObject)
        {
            isLeftButtonDown = false;
        }
        else if (eventData.pointerCurrentRaycast.gameObject == rightButton.gameObject)
        {
            isRightButtonDown = false;
        }
    }

    private void OnLeftButtonClick()
    {
        isLeftButtonDown = true;
        isRightButtonDown = false;
    }

    private void OnRightButtonClick()
    {
        isRightButtonDown = true;
        isLeftButtonDown = false;
    }
}
 */