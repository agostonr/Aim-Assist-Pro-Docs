### Version 2.0.1
- AimLock can be configured to disengage when the target's center is reached within a set radius.

### Version 2.0.0

- upgraded the demo scene and added a practice range with various targets
- added a built project open to try out for anyone
- moved the actual scripts and the practice range under a different assembly definition for better separation
- breaking change - the aim assists meant for production are in their own assembly "AimAssistPro". Find them in AimAssistPro > Source. 
- there's a demo scene for the practice range and it has its own assembly "PracticeRange". 
- created editor utilities (todo implement auto instantiation from editor utility). 
- there's only one practice range scene, and it handles the different configurations based on preprocessor directives.
- added reticles that show the effective aim assist radius
- new target selection: cone (using lines and spheres in a cone shape)
- breaking change - each aim assist has its own target selector for more flexibility. disabling the aim assist disables its target selector as well. 
- Magnetism no longer needs the movement input delta as a parameter
- new aim assist: Motion Tracker
- added code comments to communicate the intention better
- now different configurations for different targets are supported
- breaking change - IPlayerPhysicsInfo interface has been replaced with the PlayerPhysicsInfo abstract class
- LegacyPlayerPhysicsInfo: serves the previous, manual drag and drop setting of the rigidbody or character controller
- AutomaticPlayerPhysicsInfo: finds the rigidbody or charactercontroller automatically. supports kinematic rigidbodies.
- breaking change - simplified the namespaces by a lot. make sure to clear the old namespaces and reimport the new ones.
- AimAssistCameraManager: a component that finds the camera to use automatically, or lets the player define a manual override. 
  works with cinemachine's multi-camera setup but does not require CM to be used.
- separate layers are introduced for aim assist targets and the map (or objects that block the aim assist) - improves performance
- automatic integrator: handle camera pitch and player turn automatically, and in case of CM notify the player when it's configured to hard track a target.
- added checks and notifications for self collision to speed up debugging if there is anything wrong with aim assist
- logs in the aim assist assembly are only enabled in editor.
- AimAssistResult has been deprecated. Use the Rotation struct instead as that's returned from the rotational assists.
- removed the 'Helper' folder as it was just bloat
- The TargetSelectorDebugDrawer is deprecated. There's a better alternative,
- Added DebugDrawer that draws target selection lines and spheres, only in the editor. different instance for different aim assists.
- AimAssistTarget can now return the collision volume's center as well as the GameObject pivot (transform position). You can also use a proxy, which is another transform set in the inspector.
- simplified the scripts icons - a crosshair is an aim assist script, and a hit mark is the target
- added a lot of reminders in the form on logs where something has to be set up but isn't. these logs are only present in the editor to prevent a performance hit.
- the LookInputBasedAimAssistChainer is deprecated. Use the InputAimAssistManager instead. 
- for unity input system, added AimAssistInputProcessor that calls the input aim assist manager to integrate the input with
- friction now takes the target collider's average volume into consideration
- added presets for the debug drawers and aim assists
- AutoAim has now two factors (strength at center and edge), instead of one and the end result is interpolated between the two
- AutoAim now supports inverted input
- AimLock uses an interpolated player position, making rotations at high speed somewhat smoother.
- Per target overrides are available for each aim assist. Configurable on AimAssistTarget.
- Menu is added to equip object with aim assist

### Version 1.2.5

- Fixed a bug where assist wasn't working with the editor's reload on play disabled.
- Changed the root package folder so it doesn't contain the publisher first.

### Version 1.2.4

Added an example scene for the Input Manager.

### Version 1.2.3

Fixed mouse handling for the test scene.

### Version 1.2.2

Fixed the layers for the spherecast.

### Version 1.2.1

Fixing an issue that the demo scenes' dependencies did not import automatically.

### Version 1.2.0

This release will introduce changes to the public methods on the aim assist classes. 
The changes are accomodated fast though. Let's see all of them - 

 - Changed Magnetism's input parameters - it only requires a move input Vector2.
 - Changed PrecisionAim's input parameters - it only requires a look input Vector2.
 - Changed AutoAim's input parameters - it only requires a look input Vector2.
 - Changed AimLock's method name from SnapAim to AssistAim (as others). It requires no input parameters.

 - Unified the demo scenes - on each of them you can find all aim assists and you can combine them in a game menu. Press ESC or controller Start and click on the aim assists you want to enable. There are 4 scenes - 2 first person (character controller and rigidbody) and 2 third person for the same two.
 - Removed the InputManager option from the demo scenes, they only work with Unity's Input System now. Naturally, the aim assists themselves are unaffected. 
 - Changed the namespaces of the aim assists so they adhere to .net best practices more. If you cannot find the scripts you used to be able to, just add the necessary using statements.
 - No aim assist scripts require the reference to the camera's transform anymore - the TargetSelector will provide them with that. 
Increased the minimum Unity version to 2020.3 - this was a requirement from the Asset Store. 
--------
### Version 1.1.0
 - Changed PrecisionAim's input parameters: it takes a struct named PrecisionAimInput, which contains the player input delta and the deltatime to use. The result is the same as before.
 - Upgraded PrecisionAim so that it eases out the player's sensitvity to prevent an abrupt return to unassisted aim (while not looking at a target anymore).
 - NEW AIM ASSIT: AutoAim. See the docs for more details.
 - New events for TargetSelector that notify when it has found a new target and when it has lost the target.
 - Added a short legend for controls to all test scenes
 - Changed the minimum Unity version to 2019, so more users can access the project if they wanted to.
--------
### Version 1.0.1
 - Added directive to not import the input system in a script, if the package is not enabled (prevent error on package import)
 - Added new icons for all the aim assist scripts to make them easily distinguishable
 - Added a projector to the demo scenes so it's more obvious when aim assist should take effect
--------
### Version 1.0.0

Aim assist code:
 - Target Selector to pick targets for Aim Assist
 - Magnetism to compensate for player strafing
 - Aim Lock to aim for the player
 - Aim Ease In to avoid diagonal aim
 - Precision Aim to slow down look while aiming at a target.
 - The package includes the scripting reference and documentation too that details how to set up the asset.
Demo scenes are included for every aim assist.
