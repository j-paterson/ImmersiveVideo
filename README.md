> ### 360 Video with Spatial Audio
> A basic 360 video player with support for audio and recentering

## Documentation
This project uses the Skybox as the surface for playing a 360 video stored in the VideoClips folder.

The SkyboxPlayer has both a Video Player and an Audio Source attached to it as well as a script called 'Audio Sync'.

The Video Player is rendering the video clip 'empathy' to the VideoMaterial. This material uses the Skybox shader in order to display on the skybox.
This material also uses a basic texture called VideoMaterialTexture with the same dimensions as the video to prevent scaling/shearing.

The Audio Source uses the audio from the video file as its Audio Clip. It also using the Oculus Spatializer to make full use of spatial audio.

The 'Audio Sync' script prepares the video file and adds an offset between playing the video and audio clips so that they are synced correctly.

There is a 'Recenter' script attached to the OVRCameraRig, under VRTKSDK > OculusSDK. This recenter script checks to see if the player is holding the index trigger or A button on the right controller for at least 3 seconds and responds by recentering the scene.

## Steps to add a new video clip

1. Add the video file to the VideoClips folder. (Audio Optional) Add the audio file to the AudioClips folder.
2. Change the VideoMaterialTexture size to match the video file dimensions.
3. Adjust the VideoMaterial to use the correct 3d layout, Select Over Under or Side by Side, depending on stereoscopic format. Use None if the video is not stereoscopic.
4. Drag and drop the video file into the SkyboxPlayer object's Video Player component 'Video Clip' attribute.
5. (Audio Optional) Drag and drop the audio file into the SkyboxPlayer object's Audio Source component 'AudioClip' attribute.

## Improvements

At the moment, it is necessary to create a separate audio file from the video file so as to use the 3d sound settings of the Audio Source component. In the future, it would be ideal to automate this and pull the audio directly from the video file.

## License

Code released under the [MIT License].

Any Third Party Licenses can be viewed in [THIRD_PARTY_NOTICES.md].

[MIT License]: LICENSE.md
[THIRD_PARTY_NOTICES.md]: THIRD_PARTY_NOTICES.md

[Fork]: http://help.github.com/fork-a-repo/
[Open a Pull Request]: https://help.github.com/articles/using-pull-requests/
