﻿using System;

namespace CryptoInkLib
{
	public enum RC
	{
		RC_OK 							= 0,
		RC_WRONG_PW 					= 201,
		RC_PROVIDER_NOT_FOUND 			= 202,
		RC_USERNAME_NOT_AVAILABLE		= 203,
		RC_PGP_KEY_COULD_NOT_BE_CREATED = 301,
		RC_COULD_NOT_INIT_EMAIL			= 401,
		RC_COULD_NOT_INIT_XMPP			= 402,
		RC_INBOX_NOT_AVAILABLE			= 403
	}
}

