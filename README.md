# AddressablesBrokenRuntimeBundlesRepro
Repro project for broken addressables runtime bundles

After upgrading from addressables 1.16.15 to a newer versions, build bundles are no longer usable in a standalone build.
For more infor see https://forum.unity.com/threads/addressables-not-loading-in-build.925982

Addressables should always behave the same and load the green material from bundles.
Actually:

- Using "Asset database" and playing "SampleScene": Green
- Building bundles and using "Use built bundles" and playing "SampleScene": Green
- Building bundles and building a standalone player and starting it: Red (because loads of exceptions that bundle paths can't be found)

The reason is that bundle paths in the catalog no longer match the actual bundle locations (see https://forum.unity.com/threads/addressables-not-loading-in-build.925982/page-2#post-6800588)
