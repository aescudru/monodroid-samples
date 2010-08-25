//
// Copyright (C) 2007 The Android Open Source Project
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//      http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//

using System;

using Android.App;
using Android.Graphics;
using Android.OS;
using Android.Text;
using Android.Text.Method;
using Android.Text.Style;
using Android.Widget;
using Java.Lang;

namespace MonoDroid.ApiDemo
{
	public class Linkify : Activity
	{
		public Linkify (IntPtr handle)
			: base (handle)
		{
		}

		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			SetContentView (R.layout.link);

			// text1 shows the android:autoLink property, which
			// automatically linkifies things like URLs and phone numbers
			// found in the text.  No java code is needed to make this
			// work.

			// text2 has links specified by putting <a> tags in the string
			// resource.  By default these links will appear but not
			// respond to user input.  To make them active, you need to
			// call setMovementMethod() on the TextView object.

			TextView t2 = (TextView)FindViewById (R.id.text2);
			t2.MovementMethod = LinkMovementMethod.Instance;

			// text3 shows creating text with links from HTML in the Java
			// code, rather than from a string resource.  Note that for a
			// fixed string, using a (localizable) resource as shown above
			// is usually a better way to go; this example is intended to
			// illustrate how you might display text that came from a
			// dynamic source (eg, the network).

			//TextView t3 = (TextView)FindViewById (R.id.text3);
			//t3.Text = (CharSequence)Html.FromHtml (
			//                "<b>text3:</b>  Text with a " +
			//                "<a href=\"http://www.google.com\">link</a> " +
			//                "created in the Java source code using HTML.");

			//t3.MovementMethod = LinkMovementMethod.Instance;

			// text4 illustrates constructing a styled string containing a
			// link without using HTML at all.  Again, for a fixed string
			// you should probably be using a string resource, not a
			// hardcoded value.

			//SpannableString ss = new SpannableString ("text4: Click here to dial the phone.");

			//ss.SetSpan (new StyleSpan (Typeface.Bold), 0, 6,
			//           SpannedConsts.SpanExclusiveExclusive);
			//ss.SetSpan (new URLSpan ("tel:4155551212"), 13, 17,
			//           SpannedConsts.SpanExclusiveExclusive);

			//TextView t4 = FindViewById<TextView> (R.id.text4);

			//t4.Text = ss;
			//t4.MovementMethod = LinkMovementMethod.Instance;
		}
	}
}