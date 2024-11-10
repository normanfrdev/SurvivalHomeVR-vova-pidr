using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Unity.VisualScripting
{
	[AddComponentMenu("")]
	[Obsolete("UnityMessageListener is deprecated and has been replaced by separate message listeners for each event, eg. UnityOnCollisionEnterMessageListener or UnityOnButtonClickMessageListener.")]
	public sealed class UnityMessageListener : MessageListener, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IDropHandler, IScrollHandler, ISelectHandler, IDeselectHandler, ISubmitHandler, ICancelHandler, IMoveHandler
	{
		private void Start()
		{
		}

		public void AddGUIListeners()
		{
		}

		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		public void OnPointerExit(PointerEventData eventData)
		{
		}

		public void OnPointerDown(PointerEventData eventData)
		{
		}

		public void OnPointerUp(PointerEventData eventData)
		{
		}

		public void OnPointerClick(PointerEventData eventData)
		{
		}

		public void OnBeginDrag(PointerEventData eventData)
		{
		}

		public void OnDrag(PointerEventData eventData)
		{
		}

		public void OnEndDrag(PointerEventData eventData)
		{
		}

		public void OnDrop(PointerEventData eventData)
		{
		}

		public void OnScroll(PointerEventData eventData)
		{
		}

		public void OnSelect(BaseEventData eventData)
		{
		}

		public void OnDeselect(BaseEventData eventData)
		{
		}

		public void OnSubmit(BaseEventData eventData)
		{
		}

		public void OnCancel(BaseEventData eventData)
		{
		}

		public void OnMove(AxisEventData eventData)
		{
		}

		private void OnBecameInvisible()
		{
		}

		private void OnBecameVisible()
		{
		}

		private void OnCollisionEnter(Collision collision)
		{
		}

		private void OnCollisionExit(Collision collision)
		{
		}

		private void OnCollisionStay(Collision collision)
		{
		}

		private void OnCollisionEnter2D(Collision2D collision)
		{
		}

		private void OnCollisionExit2D(Collision2D collision)
		{
		}

		private void OnCollisionStay2D(Collision2D collision)
		{
		}

		private void OnControllerColliderHit(ControllerColliderHit hit)
		{
		}

		private void OnJointBreak(float breakForce)
		{
		}

		private void OnJointBreak2D(Joint2D brokenJoint)
		{
		}

		private void OnMouseDown()
		{
		}

		private void OnMouseDrag()
		{
		}

		private void OnMouseEnter()
		{
		}

		private void OnMouseExit()
		{
		}

		private void OnMouseOver()
		{
		}

		private void OnMouseUp()
		{
		}

		private void OnMouseUpAsButton()
		{
		}

		private void OnParticleCollision(GameObject other)
		{
		}

		private void OnTransformChildrenChanged()
		{
		}

		private void OnTransformParentChanged()
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		private void OnTriggerExit(Collider other)
		{
		}

		private void OnTriggerStay(Collider other)
		{
		}

		private void OnTriggerEnter2D(Collider2D other)
		{
		}

		private void OnTriggerExit2D(Collider2D other)
		{
		}

		private void OnTriggerStay2D(Collider2D other)
		{
		}
	}
}
