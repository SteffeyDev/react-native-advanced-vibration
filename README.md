
# react-native-advanced-vibration

## Getting started

`$ npm install react-native-advanced-vibration --save`

### Mostly automatic installation

`$ react-native link react-native-advanced-vibration`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-advanced-vibration` and add `RNAdvancedVibration.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNAdvancedVibration.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNAdvancedVibrationPackage;` to the imports at the top of the file
  - Add `new RNAdvancedVibrationPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-advanced-vibration'
  	project(':react-native-advanced-vibration').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-advanced-vibration/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-advanced-vibration')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNAdvancedVibration.sln` in `node_modules/react-native-advanced-vibration/windows/RNAdvancedVibration.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Advanced.Vibration.RNAdvancedVibration;` to the usings at the top of the file
  - Add `new RNAdvancedVibrationPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNAdvancedVibration from 'react-native-advanced-vibration';

// TODO: What to do with the module?
RNAdvancedVibration;
```
  