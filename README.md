# Rounded image implementation for Unity UI

This package is an implementation of a UI rounded image as BaseMeshEffect.
It uses additionnal channels of UI Canvas (TexCoord1 and TexCoord2) to pass rounded informations to the shader.

# How to use
- Set your canvas Additional Shader Channels using TexCoord1 and TexCoord2
- Add image RoundedCornerEffect Monobehaviour next to your image to round
- Add a rounded image material to your image material
- Adjust corner radius

# Sample
- Look at the sample scene in Tests folder if you have any doubt

# Registry 
npmjs regisry : **com.adlucem.ui.roundedimage**

Add these lines in *Packages/manifest.json* of your project.

```
"scopedRegistries": [
  {
    "name": "adlucem",
    "url": "https://registry.npmjs.com",
    "scopes": [
      "com.adlucem"
    ]
  }
],
"dependencies": {
  "com.adlucem.ui.roundedimage": "X.X.X",
  ...
  }
```