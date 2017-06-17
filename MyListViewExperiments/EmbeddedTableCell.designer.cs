// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace MyListViewExperiments
{
    [Register ("EmbeddedTableCell")]
    partial class EmbeddedTableCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel KeyLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel ValueLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (KeyLabel != null) {
                KeyLabel.Dispose ();
                KeyLabel = null;
            }

            if (ValueLabel != null) {
                ValueLabel.Dispose ();
                ValueLabel = null;
            }
        }
    }
}