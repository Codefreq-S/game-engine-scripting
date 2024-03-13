using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

namespace Week6
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] InputAction moveAction;
        InputAction jumpAction;
        [SerializeField] InputAction fireAction;
        [SerializeField]

        PlayerControllerMappings mappings;
        Rigidbody rb;

        public PlayerControls playerControls;

        private float mouseDeltaX = 0f;
        private float mouseDeltaY = 0f;
        private float cameraRotX = 0f;
        private int rotDir = 0;
        private bool grounded;

        private InputAction move;
        private InputAction look;
        private InputAction jump;

        [SerializeField] float jumpForce = 5f;
        const float SPEED = 5.5f;

        private float HEALTH = 10f;

        private void Awake()
        {
            mappings = new PlayerControllerMappings();
            rb = GetComponent<Rigidbody>();
            //Cursor.visible = false;
            //Cursor.lockState = CursorLockMode.Locked;

            move = playerControls.Player.Move;
            //fire = playerControls.Player.Fire;
            look = playerControls.Player.Look;
            //moveAction = mappings.Player.Move;
            //jumpAction = mappings.Player.Jump;

            //jumpAction.performed += Jump;
        }

        private void OnEnable()
        {
            moveAction = mappings.Player.Move;
            moveAction.Enable();

            jumpAction = mappings.Player.Jump;
            jumpAction.Enable();
            jumpAction.performed += Jump;

            fireAction = mappings.Player.Fire;
            fireAction.Enable();
            fireAction.performed += Fire;
        }

        private void OnDisable()
        {
            moveAction.Disable();
            jumpAction.Disable();
            fireAction.Disable();

            fireAction.performed -= Fire;
            jumpAction.performed -= Jump;
        }

        bool IsGrounded()
        {
            // Bit shift the index of the layer (8) to get a bit mask
            int layerMask = 1 << 3;

            RaycastHit hit;

            // Does the ray intersect any objects excluding the player layer
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.up * -1), out hit, 1.1f, layerMask))
            {
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.up * -1) * hit.distance, Color.yellow);
                return true;
            }
            else
            {
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.up * -1) * 1000, Color.white);
                return false;
            }
        }

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            //Returns a vector2 with values of the format (x,y) where
            //x represents our input from A and D
            //y represents our input from W and S
            //on a range from -1 to +1
            Vector2 input = moveAction.ReadValue<Vector2>();
            input *= SPEED; //* Time.deltaTime;

            /*transform.position = new Vector3(transform.position.x + input.x
                                            , transform.position.y
                                            , transform.position.z + input.y);*/

            rb.velocity = new Vector3(input.x, rb.velocity.y, input.y);
        }

        void Jump(InputAction.CallbackContext context)
        {
            if (IsGrounded() == false)
            {
                return;
            }
            rb.AddForce(Vector3.up * jumpForce);
            Debug.Log("I Jumped");
        }

        void Fire(InputAction.CallbackContext context)
        {
            Debug.Log("Fired");
        }
    }
}