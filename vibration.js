/**
 * @providesModule react-native-advanced-vibration
 */

import {
  NativeModules,
  Platform
} from 'react-native';
const RNAdvancedVibration = NativeModules.RNAdvancedVibration;

if (Platform.OS === 'ios')
  RNAdvancedVibration.prepare();

export default class Vibration {
  static triggerSelectionFeedback() {
    if (Platform.OS === 'ios')
      RNAdvancedVibration.triggerSelectionFeedback();
  }
}

