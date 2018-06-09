package com.magicsoftware.magicdev;

import com.google.firebase.iid.FirebaseInstanceId;
import com.magicsoftware.core.CoreApplication;

import java.util.Locale;

public class MainApplication extends CoreApplication {
	
	@Override
	public String userDefinedFunction(String str) {
		switch (str.toLowerCase(Locale.getDefault())) {
			case "getargs":
				// Return the URI intent args (when launched from another application)
				return MainActivity.intentArgs;
			case "getpushid":
				// Return the push notification unique GCM ID - for push notification
				return FirebaseInstanceId.getInstance().getToken();
			default:
				//User to add free code
				return "Return String";
		}
	}
}
