using UnityEngine;

public class ZombieCharacterControl : MonoBehaviour
{
	private enum ControlMode
	{
		Tank = 0,
		Direct = 1
	}

	[SerializeField]
	private float m_moveSpeed;

	[SerializeField]
	private float m_turnSpeed;

	[SerializeField]
	private Animator m_animator;

	[SerializeField]
	private Rigidbody m_rigidBody;

	[SerializeField]
	private ControlMode m_controlMode;

	private float m_currentV;

	private float m_currentH;

	private readonly float m_interpolation;

	private Vector3 m_currentDirection;

	private void Awake()
	{
	}

	private void FixedUpdate()
	{
	}

	private void TankUpdate()
	{
	}

	private void DirectUpdate()
	{
	}
}
