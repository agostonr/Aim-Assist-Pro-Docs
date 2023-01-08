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
