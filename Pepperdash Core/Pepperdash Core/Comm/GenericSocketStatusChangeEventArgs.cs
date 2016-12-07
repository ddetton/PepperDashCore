﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Crestron.SimplSharp;
using Crestron.SimplSharp.CrestronSockets;


namespace PepperDash.Core
{
	public delegate void GenericSocketStatusChangeEventDelegate(ISocketStatus client);


	/// <summary>
	/// 
	/// </summary>
	public class GenericSocketStatusChageEventArgs : EventArgs
	{
		public ISocketStatus Client { get; private set; }

		public GenericSocketStatusChageEventArgs() { }

		public GenericSocketStatusChageEventArgs(ISocketStatus client)
		{
			Client = client;
		}
	}

}