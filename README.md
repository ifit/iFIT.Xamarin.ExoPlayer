# iFIT.Xamarin.ExoPlayer
[![Build](https://github.com/ifit/iFIT.Xamarin.ExoPlayer/actions/workflows/build_and_publish_nuget.yml/badge.svg)][Build] 
[![Nuget](https://img.shields.io/nuget/v/iFIT.Xamarin.ExoPlayer)][Nuget]

Xamarin.Android bindings library for the [ExoPlayer][].  
Built with [Sufficient Bindings Approach][SBA article].

ExoPlayer is an application level media player for Android. It provides an
alternative to Android’s MediaPlayer API for playing audio and video both
locally and over the Internet. ExoPlayer supports features not currently
supported by Android’s MediaPlayer API, including DASH and SmoothStreaming
adaptive playbacks. Unlike the MediaPlayer API, ExoPlayer is easy to customize
and extend, and can be updated through Play Store application updates.

## Included Java Libraries

Please note, that this bindings library includes the following java libraries combined into a single package:
* exoplayer
* exoplayer-common
* exoplayer-extractor
* exoplayer-core
* exoplayer-dash
* exoplayer-hls
* exoplayer-smoothstreaming
* exoplayer-transformer
* exoplayer-ui

## Support

* Feel free to open any issue.
* Feel free to open a Pull Request with some updates for API exposing or other stuff.
* Please note that [SBA][SBA article] principles and recommendations should be applied to your PR in order to be approved.

## Documentation ##

* The [SBA article][] provides all information about the Sufficient Bindings Approach
* The [developer guide][] provides a wealth of information.
* The [class reference][] documents ExoPlayer classes.
* The [release notes][] document the major changes in each release.
* Follow the [developer blog][] to keep up to date with the latest ExoPlayer
  developments!

## Using ExoPlayer ##

The iFIT.Xamarin.ExoPlayer package is available on [Nuget][].

Check out the sample project in order to understand how to use the ExoPlayer in your applicaiton.

For more details it's better to check the [developer guide][], the API is very similar to the C# code so it should be easy to translate from java world.

[ExoPlayer]: https://exoplayer.dev
[Build]: https://github.com/ifit/iFIT.Xamarin.ExoPlayer/actions/workflows/build_and_publish_nuget.yml
[Nuget]: https://www.nuget.org/packages/iFIT.Xamarin.ExoPlayer
[SBA article]: https://saratsin.medium.com/how-to-bind-a-complex-android-library-for-xamarin-with-sba-9a4a8ec0c65f
[developer guide]: https://google.github.io/ExoPlayer/guide.html
[class reference]: https://google.github.io/ExoPlayer/doc/reference
[release notes]: https://github.com/google/ExoPlayer/blob/release-v2/RELEASENOTES.md
[developer blog]: https://medium.com/google-exoplayer
