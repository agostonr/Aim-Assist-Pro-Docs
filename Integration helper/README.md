# Instructions for Aim Assist Pro's integration helper

If you have concerns whether you could integrate Aim Assist Pro into your project with the already purchased third party assets, you can try out the dummy scripts provided in this repository, in the folder **Integration helper**. 

## Integration happens through code

Due to the wide availability of third party input and character control methods as well as in-house solutions and multiple options from Unity, integration has to happen via code. 
The examples in the documentation and test scenes are based on Unity's First Person Controller template. 

The scripts themselves won't do anything obviously, but their structure and public interface is the same as the actual scripts in the asset. 
Import the dummies to your project and try to integrate them based on the docs. 

To see how to integrate the asset, check out the public documentation here: https://github.com/agostonr/Aim-Assist-Pro-Docs/blob/main/Aim_Assist_Pro_Documentation.pdf
starting from page 12. 

- PrecisionAimDummy contains an example to integrate aim assists that tweak player input.
- MagnetismDummy contains an example to integrate aim assists that rotate the camera based on a given input. 
