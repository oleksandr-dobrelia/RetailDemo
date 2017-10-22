﻿namespace Messages
{
	using System;
	using NServiceBus;

	public class DeliveryRequestRefusedEvent : IEvent
	{
		public Guid CartId { get; }

		public DeliveryRequestRefusedEvent(Guid cartId)
		{
			CartId = cartId;
		}
	}
}