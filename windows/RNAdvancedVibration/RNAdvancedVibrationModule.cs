using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Advanced.Vibration.RNAdvancedVibration
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNAdvancedVibrationModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNAdvancedVibrationModule"/>.
        /// </summary>
        internal RNAdvancedVibrationModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNAdvancedVibration";
            }
        }
    }
}
