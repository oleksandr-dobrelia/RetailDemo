﻿namespace Messages
{
	using System;
	using NServiceBus;

	public class CheckCustomerPaymentHistoryCommand : ICommand
	{
		public Guid CartId { get; }

		public CheckCustomerPaymentHistoryCommand(Guid cartId)
		{
			CartId = cartId;
		}
	}
}