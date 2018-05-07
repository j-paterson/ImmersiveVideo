> ### 360 Video with Spatial Audio
> A basic project built to show capabilities with unity

## Documentation
This project uses the Skybox as the surface for playing a 360 video stored in the VideoClips folder.

The SkyboxPlayer has both a Video Player and an Audio Source attached to it as well as a script called 'Audio Sync'.

The Video Player is rendering the video clip 'empathy' to the VideoMaterialTexture. This material uses the Skybox shader in order to display on the skybox.
This material also uses a basic texture with the same dimensions as the video to prevent scaling/shearing.

The Audio Source uses the audio from the video file as its Audio Clip. It also using the Oculus Spatializer to make full use of spatial audio.

The 'Audio Sync' script prepares the video file and adds an offset between playing the video and audio clips so that they are synced correctly.

There is a 'Recenter' script attached to 

## License

Code released under the [MIT License].

Any Third Party Licenses can be viewed in [THIRD_PARTY_NOTICES.md].

[MIT License]: LICENSE.md
[THIRD_PARTY_NOTICES.md]: THIRD_PARTY_NOTICES.md

[Fork]: http://help.github.com/fork-a-repo/
[Open a Pull Request]: https://help.github.com/articles/using-pull-requests/
